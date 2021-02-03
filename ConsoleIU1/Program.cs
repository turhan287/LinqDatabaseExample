using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager(new InMemoryStudentDal());
            foreach (var student in studentManager.GetAll())
            {
                Console.WriteLine(student.Adi+" "+student.Soyadi);
            }
        }
    }
}
