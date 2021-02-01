using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class MusteriManager
    {
        //naming convention
        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine(musteri.MusteriAdi + " adlı müşteri eklendi..");

        }

        public void MusteriSil(Musteri musteri)
        {

            Console.WriteLine(musteri.MusteriAdi + " adlı müşteri silindi..");

        }

        public void MusteriListele(Musteri[] musteri)
        {

            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine("Müşterinin adı: "+ musteriler.MusteriAdi);
                Console.WriteLine("Müşterinin soyadı: " + musteriler.MusteriSoyadi);
                Console.WriteLine("Müşterinin telNo: " + musteriler.MusteriTelNo);
                Console.WriteLine("Müşterinin e posta: " + musteriler.MusteriEposta);



            }

        }

    }
}
