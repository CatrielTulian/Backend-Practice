using Contract.Persons.Request;
using Contract.Persons.Response;

namespace Application.Interfaces
{
    public interface IPersonsService
    {
        void CreatePerson(PersonRequest request);
        List<PersonResponse> GetAllPersons();
        PersonResponse? GetPersonById(int personId);
        bool UpdatePerson(int personId, PersonRequest request);
        bool DeletePerson(int personId);
    }
}
