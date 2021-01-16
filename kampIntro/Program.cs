using System;

namespace kampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           // type safety -tip güvenliği
           // Do not repeat yourself-- kendini tekrarlama

            //değişken=değer tutucu   Alians--


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu göster");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu göster");
            }



            //if yaz 2 kez TAB a bas yapı çıkıyor
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);
           



        }
    }
}
