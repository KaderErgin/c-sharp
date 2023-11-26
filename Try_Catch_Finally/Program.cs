using System;

namespace tryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try // hataya neden olabilecek kodu yazıyoruz. kontrol etmek istediğimiz kodları yazıyoruz.
            {
                Console.WriteLine("Lutfen bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine()); // girdiğimiz sayiyi okumak için "readline" yaptık.
                Console.WriteLine("Girmis oldugunuz sayi:" +sayi); 
                
            }
            catch(Exception ex) // hatayı yakaladığımızda ne yapmak istiyorsak onu yapıyoruz
            {
                Console.WriteLine("Hata:" +ex.Message.ToString());
            }
            finally // bir kod bloğu hata alsın almasın çalıştırmak istediğiniz başka bir kod bloğu varsa onu finally'e yazıyoruz.
            // finally kısmı optional'dir.
            {
                Console.WriteLine("İşlem tamamlandi.");
            } 


            // Parse methodu:
            // string ifadeleri int değerlere dönüştürmek için kullanırız.


            // Özel Exception Türleri:
            try
            {
                //int a = int.Parse(null);              1. catch blogu icin
                //int a = int.Parse("test");            2. catch blogu icin
                int a = int.Parse("-20000000000");      //3. catch blogu icin
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex) // girilen degerin minimum ve maksimum sinirlari icinde olmaması.
            {
                Console.WriteLine("Cok kucuk veya cok buyuk bir deger girdiniz");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}
