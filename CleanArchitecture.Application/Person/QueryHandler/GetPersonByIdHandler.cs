using CleanArchitecture.Domain;
using MediatR;

namespace CleanArchitecture.Application;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, Person>
{
    private readonly IPersonRepository _personRepository;

    public GetPersonByIdHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        return await _personRepository.GetPersonById(request.Id);
    }
}
