using Main;
using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Betül";
            musteri1.MusteriSoyadi = "Kara";
            musteri1.MusteriTelNo = "05050505050";
            musteri1.MusteriEposta = "mail@beth.com";

            Musteri[] musteriler = new Musteri[] { musteri1 };

            //instance - class örnegi
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriListele(musteriler);
        }
    }
}
