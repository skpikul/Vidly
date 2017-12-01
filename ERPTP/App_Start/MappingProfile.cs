﻿using AutoMapper;
using ERPTP.Dtos;
using ERPTP.Models;

namespace ERPTP.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();


            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c=>c.Id, opt=>opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m=>m.Id, opt=>opt.Ignore());
        }
    }
}