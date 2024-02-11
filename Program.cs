// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities;

internal class Program
 {
     public static void Main(string[] args)
     {
         Ciziten ciziten1 = new Ciziten();
   
            SelamVer(isim:"Azra");
            SelamVer(isim:"Mino");
            SelamVer(isim:"isimsiz");
            int sonuc = Topla(9,5);

            string ogrenci1 = "Mehmet";
            string ogrenci2 = "Azra";
            string ogrenci3 = "Mino";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Mehmet";
            ogrenciler[1] = "Azra";
            ogrenciler[2] = "Mino";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "Çankırı" };
            string[] sehirler2 = new[] { "Antalya", "Muğla", "İzmir" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Mersin";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.Firstname = "Mehmet";
            person1.Lastname = "uysal";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentiy = 123;

            Person person2 = new Person();
            person2.Firstname = "Ferhat";

            foreach ( string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
         Console.ReadLine();
     }

     static void SelamVer(string isim)
     {
         
         Console.WriteLine("Selam" + " " + isim );
     }

     static int Topla(int sayi1, int sayi2)
     {
         int sonuc = sayi1 + sayi2;
             Console.WriteLine("Toplam :" + sonuc.ToString());
             return sonuc;
     }
     
     
     private static void Degiskenler()
     {
         string mesaj = "bagaj havuzu";
         double tutar = 1500; // db den gelen veridir.
         int sayi = 100;
         bool girisYapmisMi = false;

        
         
         
         Console.WriteLine(tutar*1.20);
     }
 }

class Ciziten
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
    
}
