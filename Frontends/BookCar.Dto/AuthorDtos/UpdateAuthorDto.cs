using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Dto.AuthorDtos
{
    public class UpdateAuthorDto
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public string AuthorDescription { get; set; }

    }
}
