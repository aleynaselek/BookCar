using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.Application.Features.Mediator.Results.PricingResults;

namespace BookCar.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }  
        public int Id { get; set; }
    }
}
