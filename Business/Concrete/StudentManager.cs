using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _StudentDal;
//soyut nesne ile bağlantı kurduk.
        public StudentManager(IStudentDal studentDal)
        {
            _StudentDal = studentDal;
        }
        //injeksiyon yaptık
        

        public List<Student> GetAll()
        {
            //diğer iş kodlarınında yazabiliriz. sadece getALll için yaptık.
            return _StudentDal.GetAll();
        }
    }
}
