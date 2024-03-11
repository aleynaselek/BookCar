using BookCar.Application.Features.Mediator.Queries.FeatureQueries;
using BookCar.Application.Features.Mediator.Queries.FooterAddressQueries;
using BookCar.Application.Features.Mediator.Results.FeatureResults;
using BookCar.Application.Features.Mediator.Results.FooterAddressResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
                FooterAddressID = x.FooterAddressID,
                Description = x.Description,
                Address = x.Address,
                Phone = x.Phone,
                Email = x.Email
            }).ToList();
        }
    }
}
