using BusinessEntites;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IAlumnRepository
    {
        IEnumerable<Alumn> GetAllSystemvetare();
    }
}