using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi");
            Console.WriteLine(musteri.Id + " " + musteri.AdSoyad + " " + musteri.Bakiye);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.AdSoyad + " " + musteri.Bakiye);
            }
        }
        public void Sil(Musteri musteri)
        {
            musteri = null;
            Console.WriteLine("Müşteri silindi");
        }
    }
}
