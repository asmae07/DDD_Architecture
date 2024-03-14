using Domain.Entities;
using Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, bool>
    {
        public readonly IStudentRepository studentRepository;

        public CreateStudentCommandHandler(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public async Task<bool> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            
            // creation de l'entité
            var student = new StudentEntity
            {
                Id = request.Id,
                Name = request.Name,
                Age = request.Age
            };

            // Creating the student Entity in the database
            var result = studentRepository.CreateStudent(student, cancellationToken);
            // boolean wether its created or not 
            return result;

        }
    }
}
