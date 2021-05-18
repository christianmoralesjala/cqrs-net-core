using MainLibrary.Models;
using MediatR;

namespace MainLibrary.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
}
