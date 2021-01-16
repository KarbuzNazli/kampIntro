using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention-- doğru isimlendirme kuralları
        //syntax
        public void Ekle(Urun urun)     //Urun tipinde urun adında bir parametre gönderiyoruz
                                        // parantezler metot çalışacağını belirtir
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi!"+urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urunAdi);
        }
        

        
    }
}
