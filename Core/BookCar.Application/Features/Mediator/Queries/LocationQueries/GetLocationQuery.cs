using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using BookCar.Application.Features.Mediator.Results.LocationResults;

namespace BookCar.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}
