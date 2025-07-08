using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPersonRepository
    {
        void AddPerson(Persons person);
        List<Persons> GetAllPersons();
        Persons? GetPersonById(int personId);
        void UpdatePerson(Persons person);
        void DeletePerson(int personId);
        void DeletePerson(Persons person);
    }
}
