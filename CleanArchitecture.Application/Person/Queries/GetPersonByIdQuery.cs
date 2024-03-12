using CleanArchitecture.Domain;
using MediatR;

namespace CleanArchitecture.Application;

public class GetPersonByIdQuery : IRequest<Person>
{
    public int Id { get; set; }
}
