using MainLibrary.Models;
using MediatR;

namespace MainLibrary.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
}
