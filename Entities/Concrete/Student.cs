using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int No { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Sinif { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Yasi { get; set; }
        public int Kulup { get; set; }
        public int[] Notlar { get; set; }
        public double Ortalama { get; set; }
        public bool Basarili { get; set; }
        public int OkunanKitapSayisi { get; set; }
    }
}
