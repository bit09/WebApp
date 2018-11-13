using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WebApp.Dtos;
using WebApp.Models;

namespace WebApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<CustomerDto, Customer>();

            CreateMap<Movie, MovieDto>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            CreateMap<MovieDto, Movie>();

            CreateMap<MembershipType,   MembershipTypeDto>()
                .ForMember(t => t.Id, opt => opt.Ignore());
            CreateMap<MembershipTypeDto, MembershipType>();
        }
    }
}