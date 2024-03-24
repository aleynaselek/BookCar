using BookCar.Application.Features.CQRS.Results.CarResults;
using BookCar.Application.Interfaces;
using BookCar.Application.Interfaces.CarInterfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithPricingQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithPricingQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithPricingQueryResult> Handle()
        {
            var values =  _repository.GetCarsWithPricings();
            return values.Select(x => new GetCarWithPricingQueryResult
            {
                Model = x.Car.Model,
                CoverImageUrl = x.Car.CoverImageUrl,
                BrandName = x.Car.Brand.Name,
                PricingAmount= x.Amount 
            }).ToList();
        }
    }
}
