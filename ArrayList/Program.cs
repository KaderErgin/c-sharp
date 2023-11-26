using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList listkarisik = new ArrayList();

           

            //AddRange
            Console.WriteLine("------ Add Range ------");
            //string[] renkler = { "kırmızı", "sarı", "yesil", "mor" };
            List<int> sayılar = new List<int>() { 1, 4, 8, 5 };
            //listkarisik.AddRange(renkler);
            listkarisik.AddRange(sayılar);

            foreach (var item in listkarisik)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("------ Sort ------");
            listkarisik.Sort();
            foreach (var item in listkarisik)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("------ Binary Search ------");
            Console.WriteLine(listkarisik.BinarySearch(9));


            //Reverse
            Console.WriteLine("------ Reverse ------");
            listkarisik.Reverse();

            foreach (var item in listkarisik)
            {
                Console.WriteLine(item);
            }


            //Clear
            Console.WriteLine("------ Clear ------");
            listkarisik.Clear();
            foreach (var item in listkarisik)
            {
                Console.WriteLine(item);
            }
        }
    }
}
