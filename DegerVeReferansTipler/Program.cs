using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            // sayi1 ??   cevap:sayi1=30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayilar1[0]  ??  cevap: sayilar2[0]=999

            //Neden??    int, decimal, float, double, bool==> değer tip
            //           array, class, interface==> referans tip

            // çalışma mantığı??
            //bellekte stack ve heap diye iki alan var

            //deger tip stack te tanımlanır  sayi1=10  sayi2=30    sayi1 in değeri 10, sayi2 nin değeri 30 diye okuruz

            // new bellekte yeni bir adres oluştur diyoruz aslında
            // referans tip stack te tanımlanır ve heap alanında  değer oluşturur ve arada bağlantı kurulur. adresi referans gösteriyor

            //sayilar1 --------> 101[10,20,30]  
            //sayilar2 -------->102[100,200,300]



            // sayilar1=sayilar2  ====>>>>> sayilar1 in referans numarası =sayilar2 nin referans numarası diyoruz (101 iken 102 oluyro adresi)
            //sayilar2[0]=999  =====>>>> burda sayilar2 nin 0. elemanı 999 oluyor ve sayilar1 de aynı adresi referans gösterdiği için sayilar[0]=999 olur
        }
    }
}
