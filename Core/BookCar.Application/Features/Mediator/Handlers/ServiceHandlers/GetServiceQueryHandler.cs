using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.Application.Features.Mediator.Results.ServiceResults;
using BookCar.Application.Features.Mediator.Queries.ServiceQueries;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;

namespace BookCar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                ServiceId = x.ServiceId,
                Title = x.Title,
                Description = x.Description,
                IconUrl = x.IconUrl
            }).ToList();
        }
    }
}
