﻿using Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class GetStudentQuery : IRequest <List<Student>>
    {
    }
}
