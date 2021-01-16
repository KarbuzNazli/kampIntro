using System;

namespace odev2_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //class tan nesne uretme

            urun urun1 = new urun();
            urun1.turu = "pantolon";
            urun1.degerlendirme = "***";
            urun1.fiyat = 100;
            urun1.marka = "LCW";
            urun1.beden = 38;

            urun urun2 = new urun();
            urun2.turu = "kazak";
            urun2.degerlendirme = "****";
            urun2.fiyat = 150;
            urun2.marka = "Zara";
            urun2.beden = 40;

            urun urun3 = new urun();
            urun3.turu = "elbise";
            urun3.degerlendirme = "****";
            urun3.fiyat = 250;
            urun3.marka = "koton";
            urun3.beden = 36;

            //dizi tanımlama

            urun[] urunler = new urun[] { urun1, urun2, urun3 };

            //diziyi ekrana yazdırma

            foreach (var x in urunler)
            {
                Console.WriteLine("Türü: " + x.turu + " " + "Değerlendirme: " + x.degerlendirme + 
                    " " + "Fiyat: " + x.fiyat + "TL" + " " + "Marka: " + x.marka + 
                    " " + "Beden: " + x.beden);

            }

        }
    }

    class urun
    {
        public string turu { get; set; }
        public string degerlendirme { get; set; }
        public int fiyat { get; set; }
        public string marka { get; set; }
        public int beden { get; set; }
    }
}
