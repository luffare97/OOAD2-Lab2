using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;

namespace BusinessLayer
{
    public class UnitOfWork
    {
        public UnitOfWork(Databas databas)
        {
            Databas = databas;

            ProgramRepository = new ProgramRepository(Databas);
            UtskicksListaRepository = new UtskicksListaRepository(Databas);
            StudentRepository = new StudentRepository(Databas);
            PersonalRepository = new PersonalRepository(Databas);
            AktivitetRepository = new AktivitetRepository(Databas);
            AlumnRepository = new AlumnRepository(Databas);
        }

        public AlumnRepository AlumnRepository { get; set; }
        public AktivitetRepository AktivitetRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public PersonalRepository PersonalRepository { get; set; }
        public UtskicksListaRepository UtskicksListaRepository { get; set; }
        public ProgramRepository ProgramRepository { get; set; }

        public Databas Databas { get; }
    }
}
