using BusinessEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Seed
    {
        public static void Populate(AppDbContext appDbContext)
        {
            appDbContext.Studenter.Add(new Student()
            {
                AnvändarId = "s19",
                ID=1,
                EMail ="något@hotmail.com",
                ENamn ="Erik",
                FNamn = "hej",
                TeleNr = 50550550,
                
            }) ;

            //appDbContext.SaveChanges();
        
        }
    }
}
