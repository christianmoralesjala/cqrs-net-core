using MainLibrary.Models;
using MediatR;
using System.Collections.Generic;

namespace MainLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
}
