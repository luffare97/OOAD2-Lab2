using BusinessEntites;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IAlumnRepository
    {
        IEnumerable<Alumn> GetAllSystemvetare();
    }
}