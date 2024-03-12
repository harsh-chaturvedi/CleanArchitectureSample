using CleanArchitecture.Domain;
using MediatR;

namespace CleanArchitecture.Application.Commands;

public class CreatePerson : IRequest<Person>
{
    public string Name { get; set; }

    public string Email { get; set; }
}
