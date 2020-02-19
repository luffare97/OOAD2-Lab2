using BusinessEntites;
using System.Collections.Generic;

namespace DataLayer 
{
    public interface IAktivitetRepository
    {
        IEnumerable<Aktivitet> GetAllAktiviteter();
    }
}