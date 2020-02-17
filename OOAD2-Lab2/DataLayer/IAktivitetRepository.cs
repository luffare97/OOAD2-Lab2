using BusinessEntites;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IAktivitetRepository
    {
        IEnumerable<Aktivitet> GetAllAktiviteter();
    }
}