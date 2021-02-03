using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();// datacaess deki veriye erişim sasğlar ama bu katman iş katamanıdır 
        //operasyonlar burada gerçekleşir.
    }
}
