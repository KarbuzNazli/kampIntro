using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); // Urun class ından örnek oluşturduk. Urun tipinde değişken tanımladık
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe--tip güvenli        //Urun tipi yerine var da yazabilirdik aslında 
            foreach (Urun urun in urunler)  // Urun tipinde urun takma adında bir değişken tanımlanıyor
                                            //urunler dizisinin elemanlarını tek tek urun degişkenine atıyor
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }



            Console.WriteLine("-------------Metotlar-----------------------");

            //instance-örnek
            //encapsulation -- class ta yapacağımız değişiklik class ekli sayfalarda direk değişiklik yapar ve hata vermez
            //ayrı ayrı düzensiz olacak yapıyı düzenli hale getirme işlemidir kapsülleme. Class kullanarak bu yapıyı oluşturururuz


            SepetManager sepetManager = new SepetManager();  // SepetManager class ından örnek oluşturduk
            sepetManager.Ekle(urun1);   // 5 farklı sayfada tekrar tekrar kullanabildik metodu. Class ta değişiklik yaparak tüm metot kullanımlarında değişikliğin olduğunu görürürz
            sepetManager.Ekle(urun2);    // parametre göndermek gerekiyor

           
            // üç farklı sayfada simüle ediyormuş gibi düşün
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 30,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 20,10);




        }
    }
}


// metotlar----tekrar tekrar kullanılabilirliği saglar
// Dont repeat yourself-DRY  -- Clean Code-- Best Practice