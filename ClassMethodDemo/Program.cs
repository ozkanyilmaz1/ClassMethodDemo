using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Enis";
            musteri1.Surname = "Işık";
            musteri1.Email = "enis@enis.com";
            musteri1.PhoneNumber = "05555655879";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Sezer";
            musteri2.Surname = "Çavuş";
            musteri2.Email = "sezer@sezer.com";
            musteri2.PhoneNumber = "05556469831";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "İlker";
            musteri3.Surname = "Saroğlu";
            musteri3.Email = "ilker@ilker.com";
            musteri3.PhoneNumber = "05556321796";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriAdd(musteri1);
            musteriManager.MusteriAdd(musteri2);
            musteriManager.MusteriAdd(musteri3);

            Console.WriteLine("........Sistemdeki kayıtlı müşteriler listeleniyor.......");

            List<Musteri> listMusteri = new List<Musteri> { musteri1, musteri2, musteri3 };
            musteriManager.List(listMusteri);

        }
    }
}
