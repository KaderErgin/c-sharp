using System;

namespace typeConversions
  {
    internal class Program
    {
         static void Main(string[] args)
           {

            ///İMPLİCİT CONVERSİON 
            Console.WriteLine("****** İmplicit Conversion ****");

            Byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i;" + i);

            string e = "cüneyt";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g;" + g);




            //EXPLİCİT CONVERSİON 

            Console.WriteLine("****** Explicit Conversion ****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("z" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v;" + w);


            // ** ToString Methodu ******
            Console.WriteLine("******** ToString Methodu *****");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            //System.Conver

            Console.WriteLine("***** System.Convert Sınıfı ****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + toplam);

            //Parse  STRİNG İFADELERE ÇEVRİMEK İÇİN KULLANILIR HER ZAMAN STRİNG

            Console.WriteLine("******* PARSA METOHODU *****");

            ParseMethod();
        }

        public static void ParseMethod()

        {

            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);
            Console.WriteLine("Rakam1 :" + rakam1);
            Console.WriteLine("double1 :" + double1);

        }
    }
}
