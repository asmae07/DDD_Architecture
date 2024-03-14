﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateStudentCommand : IRequest <bool>

    {
        public  int  Id  { get; set; }
        public string Name { get; set; }
        public int Age { get; set; } 


    }
}
