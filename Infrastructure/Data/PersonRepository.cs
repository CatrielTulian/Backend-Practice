using Domain.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Data
{
    public class PersonRepository : IPersonRepository
    {
        private readonly TasksDbContext _context;

        public PersonRepository(TasksDbContext context)
        {
            _context = context;
        }

        public void AddPerson(Persons person) 
        {
            _context.persons.Add(person);
            _context.SaveChanges();
        }

        public List<Persons> GetAllPersons() 
        {
            return _context.persons.ToList();
        }

        public Persons? GetPersonById(int id) 
        {
            return _context.persons.FirstOrDefault(x=> x.Id.Equals(id));
        }

        public void UpdatePerson(Persons person) 
        {
            _context.persons.Update(person);
        }
        public void DeletePerson(Persons person) 
        {
            _context.persons.Remove(person);
            _context.SaveChanges();
        }
    }
}
