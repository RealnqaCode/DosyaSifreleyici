# ✨ C# Dosya Şifreleyici (AES-256) ✨

Bu proje, **C# WinForms** kullanılarak geliştirilmiş, dosyaları **AES-256** algoritması ile şifreleyip çözebilen basit ve güvenli bir uygulamadır. 🔐

## Ne Yapar? 👇

**1. Dosya Şifreleme:** Seçilen dosyayı AES-256 algoritması ile şifreler ve `.enc` uzantılı yeni bir dosya oluşturur. 🔒

**2. Şifre Çözme:** Şifrelenmiş `.enc` dosyasını doğru şifre ile çözer ve orijinal dosyayı geri getirir. 🔓

**3. Dosya Yönetimi:**  
- Şifreleme işleminden sonra orijinal dosyayı siler.  
- Şifre çözme işleminden sonra `.enc` dosyasını otomatik olarak siler. ♻️

**4. Sürükle-Bırak Desteği:** Dosyayı uygulamaya sürükleyerek hızlıca seçebilirsiniz. 🖱️

## Kullanılan Kütüphaneler 🛠️

- `System.Security.Cryptography` (AES işlemleri için)

## 🖼️ Ekran Görüntüsü
![image](https://github.com/user-attachments/assets/fa667941-9072-4849-a462-563ee45ccc4d)


## Kullanım 🧪

1. Uygulamayı başlatın.
2. Dosya seçin veya sürükleyin.
3. Şifre girin.
4. Şifrele veya çöz düğmesine basın.
5. İşlem tamamlandığında dosya otomatik yönetilir.

## ⚠️ Uyarı

> Şifrenizi unutursanız dosyanın içeriğine **erişemezsiniz**. AES-256 algoritması nedeniyle bu işlem geri alınamaz.

---

