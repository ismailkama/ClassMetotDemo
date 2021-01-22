using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Adem";
            musteri1.MusteriSoyadi = "Büyük";
            musteri1.MusteriYasi = 22;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriSoyadi = "Yıldız";
            musteri2.MusteriYasi = 35;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Eylül";
            musteri3.MusteriSoyadi = "Kahraman";
            musteri3.MusteriYasi = 28;

            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Ekle(musteri1);
            musteriMenager.Ekle(musteri2);
            musteriMenager.Ekle(musteri3);

        }
    }
}
