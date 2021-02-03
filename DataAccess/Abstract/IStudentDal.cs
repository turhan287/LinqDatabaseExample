using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IStudentDal
    {
        List<Student> GetAll();// geri değer döndürme var
        //geri döndüreceği değeri seçerek GetAll adında metod interfacei oluşturduk.
        // Student entities katmanında bulunduğundan ekleyemez bu yüzzden 
        //dataacess üzerinde sağ tıkla add>Project refrence Entities seç
        //çünkü dataaccess katmanı entitties ile bağlantılı.

        void Add(Student student);
        // Ekleme iini yapacak metod için Student tipinde bir nesneyi gönderceğiz
        // göndereceğimiz nesenenin adı student
        void Update(Student student);

        void Delete(Student student);

        List<Student> GetAllBySinifId(int Sinif);// geri değer döndürme var
        //kuluplereSınıflara göre filtrelemek için kullandık.
    }
}
