using BookCar.Application.Interfaces.CarInterfaces;
using BookCar.Domain.Entities;
using BookCar.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;
        public CarRepository(CarBookContext context)
        {
            _context = context;
        }
        public List<Car> GetCarsWithBrand()
        {
            var values = _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }

        public List<CarPricing> GetCarsWithPricings()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y=>y.Brand).Include(z=>z.Pricing).ToList();
            return values;
        }

        public List<Car> GetLast5CarsWithBrand()
        {
            var values = _context.Cars.Include(x=>x.Brand).OrderByDescending(x=>x.CarID).Take(5).ToList();
            return values;
        }


    }
}
