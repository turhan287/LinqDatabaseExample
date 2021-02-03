using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryStudentDal : IStudentDal
    {
        List<Student> _students;
        //List<Student _ students = new List<Student>{}; bu şekilde yapmak yeri consturaocturda oluşturduk.
        public InMemoryStudentDal() //constructor
        {
           // sanki veritabanından geliyor gibi veri oluşturduk.
            _students = new List<Student> {
                new Student {No = 2, Adi = "Tuncay", Soyadi = "Çağrı", Cinsiyet = "Erkek",
                                 DogumTarihi = new DateTime(2002, 2, 27), Sinif = 4, Kulup = 0,
                                 OkunanKitapSayisi=11, Notlar = new int[] { 75, 70, 75 }},
                new Student {No = 4, Adi = "Jale", Soyadi = "İkinci", Cinsiyet = "Bayan",
                                 DogumTarihi = new DateTime(1970, 1, 28), Sinif = 3, Kulup = 1,
                                 OkunanKitapSayisi = 7, Notlar = new int[] { 100, 95, 97, 96 } },
                new Student {No = 7, Adi = "Tekin", Soyadi = "Uğurlu", Cinsiyet = "Erkek",
                                 DogumTarihi = new DateTime(1955, 3, 26), Sinif = 1, Kulup = 1,
                                 OkunanKitapSayisi = 4, Notlar = new int[] { 30, 40, 20 } },
                new Student {No = 8, Adi = "Mesut", Soyadi = "Bahtiyar", Cinsiyet = "Erkek",
                                 DogumTarihi = new DateTime(1980, 4, 25), Sinif = 4, Kulup = 1,
                                 OkunanKitapSayisi = 8, Notlar = new int[] { 70, 10, 30 } },
                new Student { No = 12, Adi = "Veli", Soyadi = "Canlı", Cinsiyet = "Erkek",
                                 DogumTarihi = new DateTime(1993, 5, 24), Sinif = 4, Kulup = 2,
                                 OkunanKitapSayisi = 8, Notlar = new int[] { 80, 40, 10 } }

            };

        }
        public void Add(Student student)
        {
            _students.Add(student);//buradaki add listenin eventi
        }

        public void Delete(Student student)
        {
            //Linq kodu yazdık singleOrDefault -- foreach yap demek herbirine p takma adını ver ve sonrada kuralı yazdık.
            Student studentToDelete = _students.SingleOrDefault(p=>p.No==student.No );
            _students.Remove(studentToDelete);// list komutunun remove u eventi
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public List<Student> GetAllBySinifId(int Sinif)
        {
            //linq ile sql kodu yazıyoruz.
            //where listedeki sınıf verisi getirdiğim sınıf verisi ile aynı ise bunları yeniden bir liste yap
            //geri gönderiyoruz. sanki select komutu gibi oldu.
            return _students.Where(p => p.Sinif == Sinif).ToList();
        }

        public void Update(Student student)
        {
            Student studentToUpdate = _students.SingleOrDefault(p => p.No == student.No);
            student.Kulup = studentToUpdate.Kulup;
            student.Cinsiyet = studentToUpdate.Cinsiyet;
            student.Adi = studentToUpdate.Adi;
            student.Basarili = studentToUpdate.Basarili;
            student.DogumTarihi = studentToUpdate.DogumTarihi;
            student.Soyadi = studentToUpdate.Soyadi;
            // devamını yazarsın.
        }
    }
}
