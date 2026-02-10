using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace SmartFireControl
{
    public partial class Form1 : Form
    {
        MqttClient client;
        string clientId;
        string mqttBroker = "broker.hivemq.com";
        char encryptionKey = 'K'; // Key açar
        public Form1()
        {
            InitializeComponent();
            SetupMqtt();
        }

        private void SetupMqtt()
        {
            try
            {
                client = new MqttClient(mqttBroker);
                clientId = Guid.NewGuid().ToString();
                client.Connect(clientId);
                LogToPanel("Sistem Online: MQTT Brokerə qoşuldu.");
            }
            catch { LogToPanel("XƏTA: Brokerlə əlaqə qurulmadı!"); }
        }

        private void LogToPanel(string msg)
        {
            lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] {msg}");
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }
       
        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTargetX.Text) || string.IsNullOrEmpty(txtTargetY.Text))
            {
                MessageBox.Show("Zəhmət olmasa hədəf koordinatlarını daxil edin!");
                return;
            }

            LogToPanel("Hədəf koordinatları emal edilir...");
            btnCalculate.Enabled = false;

          
            pbLoading.Value = 0;
            for (int i = 0; i <= 100; i += 10)
            {
                pbLoading.Value = i;
                await System.Threading.Tasks.Task.Delay(30);
            }

            try
            {
               
                double x = Convert.ToDouble(txtTargetX.Text);
                double y = Convert.ToDouble(txtTargetY.Text);

               
                double v = 45.0;
                double g = 9.81;

                
                double distance = Math.Sqrt(x * x + y * y);

              
                double azimuthRad = Math.Atan2(x, y);
                int azimuthDeg = (int)(azimuthRad * (180 / Math.PI)) + 90; // 90 dərəcə mərkəz nöqtəsidir

              
                double sin2Theta = (g * distance) / (v * v);

                if (sin2Theta <= 1)
                {
                    double angleRad = 0.5 * Math.Asin(sin2Theta);
                    int elevationDeg = (int)(angleRad * (180 / Math.PI));

                    txtDistanceResult.Text = distance.ToString("F2") + " m";
                    txtAngleResult.Text = elevationDeg.ToString() + "°";

                    txtDistanceResult.Visible = true;
                    txtAngleResult.Visible = true;
                    lblAngleResult.Visible = true;
                    lblDistanceResult.Visible = true;

                    if (azimuthDeg >= 0 && azimuthDeg <= 180)
                    {
                        trbAzimuth.Value = azimuthDeg;
                        lblAzimuthValue.Text = azimuthDeg.ToString();
                        SendMqttData("AZ", azimuthDeg);
                        await System.Threading.Tasks.Task.Delay(200); 
                    }

                
                    if (elevationDeg >= 0 && elevationDeg <= 90)
                    {
                        trbElevation.Value = elevationDeg;
                        lblElevationValue.Text = elevationDeg.ToString();
                        SendMqttData("EL", elevationDeg);
                    }

                    LogToPanel($"Hədəf kilidləndi: Mesafe={distance:F2}m, Azimut={azimuthDeg}°, Elevasiya={elevationDeg}°");
                }
                else
                {
                    LogToPanel("XƏTA: Bu məsafə üçün mərmi sürəti yetərsizdir!");
                }
            }
            catch (Exception ex)
            {
                LogToPanel("XƏTA: Rəqəm formatı düzgün deyil!");
            }

            btnCalculate.Enabled = true;
        }


        private void trbAzimuth_Scroll(object sender, EventArgs e)
        {
            lblAzimuthValue.Text = trbAzimuth.Value.ToString();
            SendMqttData("AZ", trbAzimuth.Value);
        }

        private void trbElevation_Scroll(object sender, EventArgs e)
        {
            lblElevationValue.Text = trbElevation.Value.ToString();
            SendMqttData("EL", trbElevation.Value);
        }


        private void SendMqttData(string type, int value)
        {
            if (client != null && client.IsConnected)
            {
                string rawMsg = $"{type}:{value}";
                // XOR Şifrələmə
                byte[] encrypted = Encoding.UTF8.GetBytes(rawMsg);
                for (int i = 0; i < encrypted.Length; i++)
                    encrypted[i] = (byte)(encrypted[i] ^ encryptionKey);

                client.Publish("mil/mortar/cmd", encrypted);
            }
        }

       
        private void btnFire_Click(object sender, EventArgs e)
        {
            LogToPanel("!!! ATƏŞ ƏMRİ VERİLDİ !!!");
            SendMqttData("CMD", 999); // 999 = FIRE komandası

           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
