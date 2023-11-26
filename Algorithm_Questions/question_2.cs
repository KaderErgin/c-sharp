using System;

namespace  algorithmQuestions
{
    class ikinciSoru
    {
        static void Main(string[] args)
        {
            /*Soru 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
           Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
           Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */

            Console.Write("kaç adet sayı girmek istediğinizi yazınız: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("eşitlik veya bölme şartı koyacağınız sayıyı yazınız: ");
            int m = int.Parse(Console.ReadLine());

            int[] dizi = new int[n];
            Console.WriteLine(n + " adet sayı giriniz");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen " + (i + 1) + ".pozitif sayıyı giriniz:");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % m == 0)
                {
                    Console.Write(dizi[i]+" ");
                }
                    
            }
            Console.Write(" :"+m+"'e tam bölünen sayılardır");
        }

    }

}
