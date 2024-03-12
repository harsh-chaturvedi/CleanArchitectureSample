using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain;

public sealed class Person
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
