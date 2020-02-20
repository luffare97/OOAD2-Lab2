using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.Entity;
using DataLayer;
using BusinessEntites;

namespace GUI
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoggIn());
            /*
            using (var ctx = new AppDbContext())
            {
                var student = new Student() { ENamn = "Anders" };

                ctx.Studenter.Add(student);
                ctx.SaveChanges();
            }
            */
        }

        public static void Läggtillstudent(AppDbContext databas)
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
