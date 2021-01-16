using System;

namespace odev_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //class tan yeni değişken üretme
            siparis masa1 = new siparis();
            masa1.numarasi = "10";
            masa1.icecek = "kahve";
            masa1.yiyecek = "börek";
            masa1.tatli = "kurabiye";


            siparis masa2 = new siparis();
            masa2.numarasi = "12";
            masa2.icecek = "kola";
            masa2.yiyecek = "köfte, makarna";
            masa2.tatli = "";

            siparis masa3 = new siparis();
            masa3.numarasi = "14";
            masa3.icecek = "çay, su";
            masa3.yiyecek = "";
            masa3.tatli = "yaş pasta";

            //dizi tanımlama
            siparis[] siparisler = new siparis[] { masa1, masa2, masa3 };


            //dizinin elemanlarını ekrana yazdırma

            foreach (var x in siparisler)
            {

                Console.WriteLine(x.numarasi + " " + x.icecek + " " + x.yiyecek + " " + x.tatli);

                Console.WriteLine("Masa No: " + x.numarasi + " " + "İçecek: " + x.icecek + " " + "Yiyecek: " + x.yiyecek + " " + "Tatlı: " + x.tatli);
            }

        }
    }

    class siparis
    {
        public string numarasi { get; set; }
        public string icecek { get; set; }
        public string tatli { get; set; }
        public string yiyecek { get; set; }
    }
}
