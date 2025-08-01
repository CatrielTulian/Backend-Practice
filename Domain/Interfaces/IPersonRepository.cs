﻿using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPersonRepository
    {
        void AddPerson(Persons person);
        List<Persons> GetAllPersons();
        Persons? GetPersonById(int PersonId);
        void UpdatePerson(Persons person);
        void DeletePerson(Persons person);
    }
}
