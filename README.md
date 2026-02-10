# 🛡️ Remote-Controlled Smart Mortar and Fire Control Panel 
### Uzaqdan İdarə Olunan Ağıllı Minaatan və Atəş İdarəetmə Paneli

Uzaqdan İdarə Olunan Ağıllı Minaatan və Atəş İdarəetmə Paneli, müasir müdafiə sənayesi standartlarına uyğun olaraq hazırlanmış, uzaqdan idarə olunan minaatan və ya artilleriya qurğularının avtomatlaşdırılmış idarəetmə prototipidir. Sistem hədəf koordinatlarını qəbul edir, ballistik hesablamalar aparır və MQTT protokolu üzərindən şifrlənmiş məlumatlarla icraçı mexanizmləri (servoları) hərəkətə gətirir.

---

## 🚀 Əsas Funksiyalar

### 1. Avtomatlaşdırılmış Ballistik Hesablama
İstifadəçi tərəfindən daxil edilən **X** və **Y** koordinatları əsasında sistem aşağıdakı hesablamaları saniyələr içində tamamlayır:
* **Məsafə Təyini:** Pifaqor teoremi $$d = \sqrt{x^2 + y^2}$$ ilə hədəfə qədər olan düz məsafə tapılır.
* **Azimut (Sağa-Sola Dönmə):** $\arctan$ funksiyası ilə hədəfin istiqaməti dərəcəyə çevrilir.
* **Elevasiya (Atəş Bucağı):** Hava müqaviməti və cazibə qüvvəsi ($g$) nəzərə alınmaqla ballistik düsturla hesablanır:
    $$\theta = \frac{1}{2} \arcsin\left(\frac{g \cdot d}{v^2}\right)$$



### 2. İkili İdarəetmə Rejimi
* **Avtomatik Rejim:** Koordinat daxil edildikdə servolar hesablanmış bucaqlara avtomatik gəlir.
* **Manual (Əllə) Rejim:** TrackBar elementləri vasitəsilə operator minaatanı real vaxt rejimində (**Live**) istədiyi tərəfə yönləndirə bilir.

### 3. Təhlükəsizlik və Şifrləmə
* **XOR Şifrləmə:** Windows Form ilə ESP32 arasındakı bütün MQTT paketləri XOR alqoritmi ilə şifrlənir.
* **Maneə Sensoru:** HC-SR04 Ultrasonik sensor vasitəsilə lülənin önündə maneə yoxlanılır və təhlükə anında OLED ekranda xəbərdarlıq çıxır.

### 4. Vizual Əks-əlaqə və Monitorinq
* **OLED Displey:** Cari Azimut və Elevasiya dərəcələri, həmçinin sistemin statusu (*Ready, Fire, Launched*) anlıq göstərilir.
* **NeoPixel LED Halqası:** Atəş əmri zamanı mərminin doldurulma və atəş anını simulyasiya edən dinamik effektlər (Narıncı -> Ağ parıltı).
* **Log Paneli:** Proqramın daxilində baş verən bütün əməliyyatların real vaxt rejimində mətni hesabatını təqdim edir. 

---

## 🛠 Texnologiya Steki

| Kateqoriya | Texnologiya |
| :--- | :--- |
| **Dillər** | C# (Windows Form), C++ (Arduino/ESP32) |
| **Rabitə** | MQTT (Broker: HiveMQ) |
| **Simulyasiya** | Wokwi |

### 📟 Avadanlıqlar
* **Beyin:** ESP32 Mikrokontroller
* **Mexanika:** 2x SG90 Servo Motor
* **Ekran:** SSD1306 OLED (128x64)
* **İşıq:** WS2812B NeoPixel LED Ring
* **Sensor:** HC-SR04 Ultrasonik Sensor

---


## 📝 Quraşdırma
1. Bu repozitoriyanı **Clone** edin və ya **ZIP** olaraq endirin.
2. C# layihəsini Visual Studio-da açın və NuGet vasitəsilə `M2Mqtt` kitabxanasını yükləyin.(əksər hallarda layihə ilə birlikdə avtomatik bərpa olunacaq).
3. Qovluqdakı `.sln` (Solution) faylını **Visual Studio** ilə açın.
4. Layihənin fiziki hissəsi onlayn olaraq Wokwi platformasında hazırlanmışdır. Kod yükləməyə ehtiyac qalmadan aşağıdakı linkə daxil olaraq simulyasiyanı başlada bilərsiniz:
👉 **[Wokwi Simulyasiya Linki](https://wokwi.com/projects/455588965820581889)** *(Qeyd: Simulyasiyanı başlatdıqdan sonra C# tərəfindən idarəetmə anlıq aktivləşəcək).*
