﻿using BookCar.Application.Features.CQRS.Results.CarResults;
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
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values =  _repository.GetCarsWithBrand();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                CarID = x.CarID,
                BrandID = x.BrandID,
                BrandName = x.Brand.Name,
                Model = x.Model,
                CoverImageUrl = x.CoverImageUrl,
                Km = x.Km,
                Transmission = x.Transmission,
                Seat = x.Seat,
                Luggage = x.Luggage,
                Fuel = x.Fuel,
                BigImageUrl = x.BigImageUrl,
            }).ToList();
        }
    }
}
