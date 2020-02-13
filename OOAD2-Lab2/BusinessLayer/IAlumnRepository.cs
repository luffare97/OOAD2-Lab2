using BusinessEntites;

namespace BusinessLayer
{
    public interface IAlumnRepository
    {
        Alumn GetAlumn(int AnvändarId);
    }
}