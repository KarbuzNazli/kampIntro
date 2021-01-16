using System;

namespace clas_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            string sonuc = ogrenci.Hosgeldiniz("Ali", "Gök");
            Console.WriteLine(sonuc);
        }
    }

    class Ogrenci
    {
        public string Hosgeldiniz(string Ad, string Soyad)
        {
            return Ad + " " + Soyad;
        }
    }
}
