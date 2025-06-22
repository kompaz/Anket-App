# 🗳️ AnketApp - Anket Uygulaması (C# WinForms)

Bu proje, 30 iş günü süren yaz stajım boyunca geliştirdiğim bir masaüstü **anket kayıt ve yönetim sistemi** uygulamasıdır. Kullanıcıların soru ve cevaplar oluşturup bunları kayıt altına alabildiği, ayrıca kayıtlı cevapların analiz edilebildiği bir yapıdadır.

---

## 🎯 Amaç

Staj sürecimde yazılım geliştirme döngüsünü baştan sona deneyimlemek ve C# ile nesne tabanlı programlamada uzmanlaşmak hedeflenmiştir. Bu süreç boyunca:

- Gerçek kullanıcı senaryolarına uygun veri modelleri geliştirildi,
- WinForms teknolojisi ile görsel kullanıcı arayüzleri tasarlandı,
- Veritabanı işlemleri ve kullanıcı etkileşimi yönetildi.

---

## 🧩 Proje Özellikleri

- ✅ Anket sorularını oluşturma
- ✅ Anket cevaplarını girme
- ✅ Cevap kayıtlarını veritabanında saklama
- ✅ Cevap analizlerini filtreleme ve görüntüleme
- ✅ C# WinForms arayüzü ile kullanıcı dostu tasarım
- ✅ Modüler yapı (Her işlev ayrı form/klasörde tanımlı)

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji         | Açıklama                        |
|------------------|---------------------------------|
| C#               | Programlama dili                |
| WinForms         | Masaüstü GUI uygulaması         |
| MSSQL            | Veritabanı yönetimi             |
| Visual Studio    | Geliştirme ortamı (IDE)         |
| .NET 6.0         | Framework versiyonu             |

---

## 📎 Staj Defteri ve Gelişim Süreci

30 günlük staj süreci boyunca her gün yapılan işler detaylı olarak aşağıdaki PDF'te belgelenmiştir:

📄 [Staj Defteri (PDF)](./Staj-Defteri_Sinan.pdf)

---

## 📁 Proje Klasör Yapısı (Özet)

```bash
AnketApp/
├── AnketCevapKayit.cs
├── AnketCevapSorgulama.cs
├── AnketKayit.cs
├── AnketSorgu.cs
├── AnketSoruKayit.cs
├── SoruCevapUC.cs
├── Tool.cs
├── Program.cs
├── bin/
├── obj/
└── .vs/
```

> `bin/`, `obj/`, `.vs/` gibi klasörler `.gitignore` ile versiyon kontrolüne dahil edilmemiştir.

---

## ⚙️ Kurulum

1. Bu repoyu klonlayın:
```bash
git clone https://github.com/kompaz/Anket-App.git
```

2. `AnketApp.sln` dosyasını Visual Studio ile açın.

3. Gerekirse `SQL Server` bağlantı ayarlarını yapılandırın.

4. Uygulamayı `Debug` modda çalıştırın ve anketleri test edin.

---