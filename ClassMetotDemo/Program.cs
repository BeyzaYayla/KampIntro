using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                AdSoyad = "Beyza Yayla",
                Id = "1",
                Bakiye = 20
            };

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Engin Demiroğ";
            musteri2.Id = "2";
            musteri2.Bakiye = 20000;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.Listele(musteriler);
            musteriManager.Sil(musteri2);

            Console.WriteLine(musteri2.AdSoyad);
        }
    }
}
