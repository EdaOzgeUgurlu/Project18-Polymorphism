# Project18_Polymorphism 

## 📄 Açıklama
Bu proje, C# dilinde polimorfizm kavramını kullanarak çeşitli geometrik şekillerin alan hesaplamalarını gerçekleştiren bir uygulamadır. Projede, geometrik şekilleri temsil eden bir temel soyut sınıf (`BaseGeometrikSekil`) oluşturulmuş ve bu sınıftan türetilen `Kare`, `Dikdörtgen` ve `DikUcgen` sınıfları ile her şeklin alanı hesaplanmaktadır.

### Özellikler
- **Polimorfizm Kullanımı:** Farklı geometrik şekillerin aynı metodu kullanarak alan hesaplaması.
- **Soyut Sınıf:** Temel şekil özelliklerini içeren soyut bir sınıf.
- **Çeşitli Şekiller:** Kare, dikdörtgen ve dik üçgen sınıfları ile geometrik şekil çeşitliliği.

## ⚙️ Gereksinimler
Bu projeyi çalıştırmak için aşağıdaki gereksinimlerin karşılanması gerekmektedir:
- **.NET Framework veya .NET Core:** Uygulamanın çalışması için gerekli.
- **C# Derleyicisi:** Projenin derlenmesi ve çalıştırılması için gerekli.

## 🔧 Kurulum
Projenin çalıştırılması için aşağıdaki adımları izleyin:

1. **Depoyu Klonlayın:**
   ```bash
   git clone [depo URL]
   ```

2. **Proje Klasörüne Girin:**
   ```bash
   cd Project18_Polymorphism
   ```

3. **Proje Bağımlılıklarını Yükleyin:**
   (Eğer bağımlılık varsa)
   ```bash
   dotnet restore
   ```

4. **Projeyi Derleyin ve Çalıştırın:**
   ```bash
   dotnet run
   ```

## 📊 Kullanım
- Program çalıştığında, kullanıcıya üç farklı geometrik şekil (kare, dikdörtgen, dik üçgen) için alan hesaplaması yapılır.
- Alan hesaplamaları şu formüllerle gerçekleştirilir:
  - **Kare:** Alan = Kenar * Kenar
  - **Dikdörtgen:** Alan = Genişlik * Yükseklik
  - **Dik Üçgen:** Alan = (Genişlik * Yükseklik) / 2

### Örnek Çıktı
Program çalıştığında konsolda aşağıdaki gibi bir çıktı göreceksiniz:
```
Kare Alanı: 25
Dikdörtgen Alanı: 24
Dik Üçgen Alanı: 6
```


