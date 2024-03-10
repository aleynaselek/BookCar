using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.Application.Features.Mediator.Results.FeatureResults;

namespace BookCar.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery :IRequest<GetFeatureByIdQueryResult>
    {
        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }  
        public int Id { get; set; }
    }
}
