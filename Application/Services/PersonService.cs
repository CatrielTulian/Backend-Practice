using Application.Interfaces;
using Contract.Mappings;
using Contract.Persons.Request;
using Contract.Persons.Response;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class PersonService : IPersonsService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void CreatePerson(PersonRequest person)
        {
            var personEntity = MapPersons.MapToDomain(person);
            _personRepository.AddPerson(personEntity);
        }

        public List<PersonResponse> GetAllPersons()
        {
            var persons = _personRepository.GetAllPersons();
            var personsResponse = new List<PersonResponse>();
            foreach (var person in persons)
            {
                var personResp = MapPersons.ToPersonResponse(person);
                personsResponse.Add(personResp);
            }
            return personsResponse;
        }

        public PersonResponse? GetPersonById(int personId)
        {
            var person = _personRepository.GetPersonById(personId);
            if (person != null)
            {
                return MapPersons.ToPersonResponse(person);

            }
            return null;
        }

        public bool UpdatePerson(int personId, PersonRequest person)
        {
            var personEntity = _personRepository.GetPersonById(personId);

            if (personEntity != null)
            {
                MapPersons.ToPersonEntityUpdate(personEntity, person);
                _personRepository.UpdatePerson(personEntity);
                return true;
            }
            return false;
        }

        public bool DeletePerson(int personId)
        {
            var person = _personRepository.GetPersonById(personId);
            if (person != null)
            {
                _personRepository.DeletePerson(person);
                return true;
            }
            return false;
        }
    }
}
