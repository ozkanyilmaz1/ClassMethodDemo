using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri sisteme eklendi. Müşteri adı : " + musteri.Name + " " + musteri.Surname + " " + "Müşteri ID : " + musteri.Id);
        }

        public void MusteriUptade(Musteri musteri1)
        {
            Console.WriteLine("Müşteri bilgisi düzenlendi. Yeni müşteri ad soyad: " + musteri1.Name + " " + musteri1.Surname);
        }

        public void List(List<Musteri> listMusteri)
        {
            foreach (Musteri musteri in listMusteri)
            {
                Console.WriteLine("Müşteri listeleri: \n\n"+ musteri.Id + "\n" + musteri.Name + "\n" + musteri.Surname + "\n" + musteri.Email + "\n" + musteri.PhoneNumber);
            }
        }
    }
}
