using BusinessEntites;

namespace BusinessLayer
{
    public interface IAktivitetRepository
    {
        Aktivitet GetAktivitet(int id);
    }
}