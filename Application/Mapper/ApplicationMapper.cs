using Application.Model;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class ApplicationMapper : Profile // Inherit from class Profile of the AutoMapper
    {
        // Constructeur 
        public ApplicationMapper()
        {
            // Configuration du AutoMapper
            CreateMap<StudentEntity, Student>().ReverseMap()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.Age));
            ;
            // Mapping de List<StudentEntity> vers List<Student> (et vice versa)

        }
    }
}
