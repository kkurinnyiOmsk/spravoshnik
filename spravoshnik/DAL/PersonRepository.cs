using spravoshnik.Interfaces;
using System.Linq;
namespace DAL
{
    public class PersonRepository : IPersonRepository
    {
        public Person GetPersonByNaneAndSurname(string name, string surname)
        {
            Person result;
            using (var db = new SpravoshnikEntities())
            {
                result = db.Person.FirstOrDefault(person => person.Name == name && person.Surname == surname);
            }
            return result;
        }

        public Person GetPersonByPhone(string phoneNumber)
        {
            Person result;
            using (var db = new SpravoshnikEntities())
            {
                result = db.Person.FirstOrDefault(person => person.Phone == phoneNumber);
            }

            return result;
        }
    }
}