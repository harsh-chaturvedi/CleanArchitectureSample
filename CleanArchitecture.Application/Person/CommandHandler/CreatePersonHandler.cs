using CleanArchitecture.Application.Commands;
using CleanArchitecture.Domain;
using MediatR;

namespace CleanArchitecture.Application;

public class CreatePersonHandler : IRequestHandler<CreatePerson, Person>
{
    private readonly IPersonRepository _personRepository;

    public CreatePersonHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Person> Handle(CreatePerson request, CancellationToken cancellationToken)
    {
        Person person = new Person();
        person.Email = request.Email;
        person.Name = request.Name;

        return await _personRepository.AddPerson(person);
    }
}
