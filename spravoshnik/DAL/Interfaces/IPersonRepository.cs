using DAL;

namespace spravoshnik.Interfaces
{
    public interface IPersonRepository
    {
        Person GetPersonByNaneAndSurname(string name, string surname);

        Person GetPersonByPhone(string phoneNumber);
    }
}