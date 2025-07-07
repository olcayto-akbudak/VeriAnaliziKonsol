# 📊 VeriAnalizKonsol

Bu proje, C# ile geliştirilen basit bir konsol tabanlı **veri analiz ve görselleştirme uygulamasıdır**. Proje, CSV dosyasından satış verilerini okuyarak temel analizler yapar, filtreleme seçenekleri sunar ve ASCII grafiklerle satışları görselleştirir.

---

## 🚀 Özellikler

- ✅ CSV dosyasından veri okuma
- ✅ Toplam, ortalama ve maksimum satış hesaplama
- ✅ Ürün veya tarihe göre filtreleme
- ✅ ASCII çubuk grafik ile görselleştirme
- ✅ Basit ve modüler yapı

---

## 🧠 Kullanılan Teknolojiler

- **C# 12** (.NET 8 ile uyumlu)
- Konsol tabanlı uygulama
- LINQ ve temel dosya işlemleri

---

## 📁 Proje Yapısı

├── Program.cs # Uygulamanın giriş noktası
├── SaleRecord.cs # Satış verilerini temsil eden sınıf
├── CsvReader.cs # CSV dosyasını okuyan yardımcı sınıf
├── GrafikGosterici.cs # ASCII grafik oluşturan sınıf
├── sales.csv # Örnek veri dosyası
└── VeriAnalizKonsol.csproj# Proje dosyası


---

## 📝 Örnek CSV (sales.csv)

'''csv
CustomerName,Product,SaleDate,Amount
Ali Yılmaz,Monitor,2024-05-01,2500
Ayşe Kara,Laptop,2024-05-02,12500
Can Demir,Mouse,2024-05-02,300



Toplam Satis Kaydi: 3
Toplam Gelir: 15300 TL
Ortalama Satis: 5100.00 TL
En Yuksek Satis: Ayşe Kara - Laptop - 12500 TL

--- FILTRELEME ---
1 - Urune gore filtrele
2 - Tarihe gore filtrele
Seciminiz:
