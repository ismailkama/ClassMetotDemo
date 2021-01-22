using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriMenager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Hoşgeldiniz Sayın" + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.MusteriYasi);
        }
    }
}
