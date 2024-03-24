using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Interfaces.CarInterfaces
{
    public interface ICarPricingRepository
    { 
        List<CarPricing> GetCarPricingWithCars();
    }
}
