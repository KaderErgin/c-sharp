using System;

namespace algorithmQuestions

{
    class birinciSoru
    {
        static void Main(string[] args)
        {
            /*Soru 1:  Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

            Console.Write("kaç adet sayı girmek istediğinizi yazınız: ");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            Console.WriteLine(n + " adet sayı giriniz");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen " + (i + 1) + ".pozitif sayıyı giriniz:");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.Write(dizi[i]+" ");
                }
                    
            }
            Console.Write(" :çift sayılardır");
        }

    }

}
