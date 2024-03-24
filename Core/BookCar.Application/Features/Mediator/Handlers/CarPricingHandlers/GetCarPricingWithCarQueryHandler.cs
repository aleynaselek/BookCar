using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.Application.Features.Mediator.Results.CarPricingResults;
using BookCar.Application.Features.Mediator.Queries.CarPricingQueries;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using BookCar.Application.Interfaces.CarInterfaces;

namespace BookCar.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetCarPricingWithCars();
            return values.Select(x => new GetCarPricingWithCarQueryResult
            {
                Amount = x.Amount,
                Brand=x.Car.Brand.Name,
                CarPricingID=x.CarPricingID,
                CoverImageUrl=x.Car.CoverImageUrl,
                Model=x.Car.Model

            }).ToList();
        }
    }
}
