using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using DataLayer;

namespace BusinessLayer
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(Databas context) : base(context)
        {
            Context = context;
        }

        private Databas Context { get; }

        public static void Läggtillstudent(Databas databas)
        {
            databas.Studenter.Add(new Student()
            {
                ID = 1,
                AnvändarId = "S100",
                ENamn = "Per",
                EMail = "Snopp@hotmail.com",
                FNamn = "Persson",
                TeleNr = 101010022,
            });
            databas.SaveChanges();
        }




    }
}
