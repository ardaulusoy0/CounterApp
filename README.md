# 🏆 CounterApp - Basit MVVM Sayaç Uygulaması

**CounterApp**, WPF ve MVVM mimarisini kullanarak **sayaç artırma ve azaltma** işlemlerini yöneten basit bir uygulamadır.  
Bu proje, **INotifyPropertyChanged, ICommand ve RelayCommand** gibi temel MVVM prensiplerini içermektedir.

## 🚀 Özellikler
✔ **Sayaç Değeri Güncellenir** (Min: 0, Max: 10)  
✔ **MVVM Mimarisine Uygun Komut Yönetimi**  
✔ **UI Otomatik Güncellenir (`OnPropertyChanged`)**  
✔ **GitHub'da Açık Kaynak Paylaşımı İçin Hazır**  

## 📂 Proje Yapısı
CounterApp/
 ├── ViewModels/
 │      ├── BaseViewModel.cs  # Temel ViewModel yapısı
 │      ├── CounterViewModel.cs  # Sayaç işlemlerini yöneten ViewModel
 ├── Commands/
 │      ├── RelayCommand.cs  # ICommand kullanımı için özel komut sınıfı
 ├── MainWindow.xaml  # Kullanıcı arayüzü
 |      ├── MainWindow.xaml.cs  # UI ve ViewModel bağlantıları
 ├── App.xaml  # WPF uygulama başlangıç ayarları
 ├── CounterApp.csproj  # Proje dosyası
 ├── README.md  # Proje açıklaması ve kullanımı
 

## 🛠 Kullanılan Teknolojiler
- **WPF (Windows Presentation Foundation)**
- **MVVM (Model-View-ViewModel)**
- **C# ve .NET**
- **Git & GitHub**

## 💻 Kurulum ve Çalıştırma
1️⃣ **Projeyi GitHub’dan Clone Et:**  
```sh
git clone https://github.com/ardaulusoy0/CounterApp.git
cd CounterApp
```
2️⃣ Projeyi Visual Studio’da aç 
3️⃣ Uygulamayı çalıştır ve sayaç değerini artırıp azalt! 🚀

###🤝 Katkıda Bulunma
Eğer projeye katkıda bulunmak istersen:
Fork yaparak kendi versiyonunu oluşturabilirsin!
Yeni özellikler ekleyip Pull Request gönderebilirsin!
Hata veya önerileri Issues kısmına ekleyebilirsin!
