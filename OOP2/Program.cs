using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.ID = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirov";
            musteri1.TcNo = "1232432432";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "5421";
            musteri2.SirketAdi = "Kodlama";
            musteri2.VergiNo = "1231313";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
