using System;

public class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Kader";
        ogrenci.Soyisim = "Ergin";
        ogrenci.OgrenciNo = 1596;
        ogrenci.Sinif = -3;
        ogrenci.OgrenciBilgileriniGetir();
        ogrenci.SinifDusur();
        ogrenci.OgrenciBilgileriniGetir();

        Ogrenci ogrenci2 = new Ogrenci("Derya", "Gunsu", 14, 1);
        ogrenci2.SinifDusur();
        ogrenci2.SinifDusur();
        ogrenci2.OgrenciBilgileriniGetir();
    }
}
class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir");
                sinif = 1;
            }
            else { sinif = value; }
        }

    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    
    {
        Isim= isim; 
        Soyisim= soyisim;
        OgrenciNo= ogrenciNo;
        Sinif= sinif;   
    }
    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("*****Öğrenci Bilgileri****");
        Console.WriteLine("Öğrenci adı      :"+ this.isim );
        Console.WriteLine("Öğrenci Soyadı   :"+ this.soyisim);
        Console.WriteLine("Öğrenci numarası :"+ this.ogrenciNo);
        Console.WriteLine("Öğrenci sınıfi :"+ this.sinif);
    
    }
    public void SinifAtlat() 
    {
        this.sinif = this.sinif +1; 
    
    }

    public void SinifDusur() 
    {
        this.sinif = this.sinif - 1;
    }


}
