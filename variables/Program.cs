using System;

namespace veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrana yazdırma
            Console.WriteLine("Hello World!");

            
            Console.WriteLine("Lütfen adınızı girin: ");
            // klavyeden adını girme
            string name = Console.ReadLine();

            //Klavyeden aldığımız veriyi ekrana bastırma 
            Console.WriteLine("Hoşgeldin " + name);

            //Değişkenleri tanımlama ve ekrana bastırma
            byte a = 5;
            Console.WriteLine(a);
            sbyte b = 50;
            Console.WriteLine(b);
            short c = 60;
            Console.WriteLine(c);
            ushort d = 70;
            Console.WriteLine(d);
            int i = 2022;
            Console.WriteLine(i);
            long l = 23092022;
            Console.WriteLine(l);
            float f = 25;
            Console.WriteLine(f);
            double e = 1555.55;
            System.Console.WriteLine(e);
            string str = "Yavuzzzzzzz";
            Console.WriteLine(str);
            bool b1 = true;
            Console.WriteLine(b1);
            bool b2 = false;
            Console.WriteLine(b2);

            //Datetime Kullanımı
            DateTime dt = DateTime.Now;
            Console.WriteLine("Şu anın tarihi: " + dt);

            //object
            object x = 12;
            Console.WriteLine(x);
            object y = "yavuz";
            Console.WriteLine(y);
            object z = 4.3;
            Console.WriteLine(z);

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Yavuz";
            Console.WriteLine(str1);

            //integer ifadeler
            int t = 2;
            int r = 4;
            //toplama işlemi
            Console.WriteLine(t + r);
            //çıkarma işlemi 
            Console.WriteLine(t - r);
            //çarpma işlemi
            Console.WriteLine(t * r);
            //bölme işlemi
            Console.WriteLine(t / r);

            //boolean ifadeler
            bool bool1 = 10 > 5;
            Console.WriteLine(bool1);

            //Değişken dönüşümleri
            string number = "123";
            int number1 = 456;
            // değişkenleri string yapıp toplar sonucu yan yana yazar
            string newStringNumber = number + number1.ToString();
            Console.WriteLine("string->new number= " + newStringNumber);
            // değişkenleri inte çevirip öyle toplar sonuç iki sayının toplamıdır
            int newIntNumber = Convert.ToInt32(number) + number1;
            Console.WriteLine("int->new number= " + newIntNumber);

            //Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Date: " + datetime);

            //Hour
            string hour = DateTime.Now.ToString("HH/mm");
            Console.WriteLine("Hour: " + hour);

        }
    }
}
