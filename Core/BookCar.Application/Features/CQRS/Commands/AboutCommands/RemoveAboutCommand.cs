﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveBannerCommand
    {
        public int Id { get; set; } 
        public RemoveBannerCommand(int id)
        {
            Id = id;
        }
    }
}
