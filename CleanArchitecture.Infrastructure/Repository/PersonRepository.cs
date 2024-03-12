using CleanArchitecture.Application;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure;

public class PersonRepository : IPersonRepository
{
    private readonly PersonDbContext _context;

    public PersonRepository(PersonDbContext context)
    {
        _context = context;
    }

    public async Task<Person> AddPerson(Person toCreate)
    {
        _context.Person.Add(toCreate);

        await _context.SaveChangesAsync();

        return toCreate;
    }

    public async Task DeletePerson(int personId)
    {
        var person = _context.Person
            .FirstOrDefault(p => p.Id == personId);

        if (person is null) return;

        _context.Person.Remove(person);

        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<Person>> GetAll()
    {
        return await _context.Person.ToListAsync();
    }

    public async Task<Person> GetPersonById(int personId)
    {
        return await _context.Person.FirstOrDefaultAsync(p => p.Id == personId);
    }

    public async Task<Person> UpdatePerson(int personId, string name, string email)
    {
        var person = await _context.Person.FirstOrDefaultAsync(p => p.Id == personId);
        person.Name = name;
        person.Email = email;

        await _context.SaveChangesAsync();

        return person;
    }
}
