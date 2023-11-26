using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degiskenOne = "Dersimiz CSharp, Hoşgeldiniz";
            string degiskenTwo = "Dersimiz CSharp";

            //Karakter Sayısı
            Console.WriteLine(degiskenOne.Length);

            //Tüm harfleri küçült/büyüt
            Console.WriteLine(degiskenOne.ToUpper());
            Console.WriteLine(degiskenTwo.ToLower());

            //Birleştir
            Console.WriteLine(string.Concat(degiskenOne, "Hello World"));

            //Karşılaştır
            Console.WriteLine(degiskenOne.CompareTo(degiskenTwo));//eşit ise 0  değişkenOne büyükse 1 degiskenTwo büyükse -1 döner
            Console.WriteLine(string.Compare(degiskenOne, degiskenTwo, true));//Büyük, küçük harf duyarsızdır.
            Console.WriteLine(string.Compare(degiskenOne, degiskenTwo, false));//Büyük, küçük harf duyarlıdır.

            //İçeriyormu
            Console.WriteLine(degiskenOne.Contains(degiskenTwo));
            Console.WriteLine(degiskenOne.EndsWith("World")); //sonunda içeriyormu
            Console.WriteLine(degiskenOne.StartsWith("Ders")); //başında içeriyormu

            //İndex nosu
            Console.WriteLine(degiskenOne.IndexOf("Derya"));//İçermiyorsa -1 döner
            Console.WriteLine(degiskenTwo.IndexOf("CS"));//İçeriyor index no 9 dan itibaren

            //Ekleme yapmak
            Console.WriteLine(degiskenOne.Insert(0, "Merhaba!"));//0. indexten başalayarak ekler.
            Console.WriteLine(degiskenOne.LastIndexOf("Pelin"));//Son indexten başlayarak ekler.

            //Boşluk  yakalamak
            Console.WriteLine(degiskenOne.PadLeft(30));//Karakter sayısını değere tamamlar.Boşluklar ekler/Yada verdiğimiz karakteri ekler.
            Console.WriteLine(degiskenOne + degiskenTwo.PadRight(30, '*'));

            //Kaldırır
            Console.WriteLine(degiskenTwo.Remove(10));//10. indexten itibaren hepsini kaldırır.
            Console.WriteLine(degiskenTwo.Remove(2, 5));//2 dahil 5 dahil değildir.

            //Değiştir
            Console.WriteLine(degiskenTwo.Replace("CSharp", "C#"));

            //Parçalamak
            Console.WriteLine(degiskenOne.Split(' ')[0]);//Boşluklara göre parçala 0. indexi yaz.

            //Alt karakterlere parçalamak
            Console.WriteLine(degiskenOne.Substring(4));//4.İndexten itibare böl ve devamının al
            Console.WriteLine(degiskenOne.Substring(4, 6));//4.indexten itibaren böl ve 6 karakter al

        }

    }

}
