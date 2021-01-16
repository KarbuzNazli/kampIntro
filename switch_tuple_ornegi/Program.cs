using System;

namespace switch_tuple_ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 10;
            int s2 = 20;
            /*
            string mesaj = "";

            switch (s1, s2)
            {
                case (5, 10):
                    mesaj = "5 ile 10 değeri göster";
                    break;
                case (10, 20):
                    mesaj = "10 ile 20 değeri göster";
                    break;
            }
            */

            //2. kullanım şekli

            string mesaj = (s1, s2) switch
            {
                (5, 10) => "5 ile 10 değeri göster",
                (10, 20) => "10 ile 20 değeri göster"
            };

            Console.WriteLine(mesaj);
                
        }
    }
}
