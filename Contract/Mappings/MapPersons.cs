using Contract.Persons.Request;
using Contract.Persons.Response;
using DomainEntity = Domain.Entities;

namespace Contract.Mappings
{
    public class MapPersons
    {
        public static Domain.Entities.Persons MapToDomain(PersonRequest Request)
        {
            return new DomainEntity.Persons()
            {
                Name = Request.Name,
                Surname = Request.Surname
            };
        }

        public static PersonResponse ToPersonResponse(Domain.Entities.Persons Person)
        {
            return new PersonResponse()
            {
                PersonId = Person.PersonId,
                Name = Person.Name,
                Surname = Person.Surname
            };
        }

        public static void ToPersonEntityUpdate(DomainEntity.Persons Person, PersonRequest Request)
        {
            Person.Name = Request.Name;
            Person.Surname = Request.Surname;
        }
    }
}
