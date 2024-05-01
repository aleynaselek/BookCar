using BookCar.Application.Interfaces.TagCloudInterfaces;
using BookCar.Application.Interfaces.TagCloudInterfaces;
using BookCar.Domain.Entities;
using BookCar.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTagCloud.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarBookContext _context;
         

        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }  

        public List<TagCloud> GetTagCloudsByBlogIdDto(int id)
        {
            var values = _context.TagClouds.Where(x => x.BlogID == id).ToList();
            return values;
        }
    }
}
