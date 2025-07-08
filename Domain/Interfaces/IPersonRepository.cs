using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPersonRepository
    {
        void AddPerson(Persons Person);
        List<Persons> GetAllPersons();
        Persons? GetPersonById(int PersonId);
        void UpdatePerson(Persons Person);
        void DeletePerson(int PersonId);
        void DeletePerson(Persons Person);
    }
}
