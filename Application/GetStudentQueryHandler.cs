using Application.Model;
using AutoMapper;
using Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Qusay.Maper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class GetStudentQueryHandler : IRequestHandler < GetStudentQuery , List<Student>>
    { 
        // two private fields 
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        // Constructeur 
        public GetStudentQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;   
        }

        // Handle method is responsible for handling requests to retrieve a list of students
        public async Task<List<Student>> Handle (GetStudentQuery request , CancellationToken cancellationToken)
        { 
            // Injection des dependances 
           // Retrieve Students by GetAll 
            var Result = _studentRepository.GetAll(cancellationToken);

            // liste Pour stocker les etudiants apres le mapping 
            var students = new List<Student>();

            // Mapper les objets par l'AutoMapper
            foreach(var student in Result)
               {
                students.Add(_mapper.Map<Student>(students));
               }


            // Renvoie la liste 
            return students;
        }
    }


}
