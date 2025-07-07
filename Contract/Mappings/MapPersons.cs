using Contract.Persons.Request;
using Contract.Persons.Response;
using DomainEntity = Domain.Entities;

namespace Contract.Mappings
{
    public class MapPersons
    {
        public static Domain.Entities.Persons MapToDomain(PersonRequest request)
        {
            return new DomainEntity.Persons()
            {
                name = request.name,
                surname = request.surname
            };
        }

        public static PersonResponse ToPersonResponse(Domain.Entities.Persons person)
        {
            return new PersonResponse()
            {
                personId = person.personId,
                name = person.name,
                surname = person.surname
            };
        }

        public static void ToPersonEntityUpdate(DomainEntity.Persons person, PersonRequest request)
        {
            person.name = request.name;
            person.surname = request.surname;
        }
    }
}
