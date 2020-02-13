using BusinessEntites;

namespace BusinessLayer
{
    public interface IPersonalRepository
    {
        Personal GetPersonal(int PersonalID);
    }
}