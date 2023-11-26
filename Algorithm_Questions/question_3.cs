using System;

namespace algorithmQuestions
{
    class ucuncuSoru
    {
        static void Main(string[] args)
        {
            /*Soru 3: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
           Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
           Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */

            Console.Write("Sıralanmasını istediğiniz kelime sayısını giriniz: ");
            int n = int.Parse(Console.ReadLine());
            string[] dizi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen " + (i + 1) + ".kelimeyi giriniz:");
                dizi[i] = Console.ReadLine();
            }

            Console.WriteLine("Girdiğiniz kelimelerin sıralanışı aşağıdaki gibidir: ");
            Array.Reverse(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            
        }

    }

}
