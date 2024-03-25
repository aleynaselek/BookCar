﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BookCar.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class CreateTagCloudCommand : IRequest
    { 
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}
