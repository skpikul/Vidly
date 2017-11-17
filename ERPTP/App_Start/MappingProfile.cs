using AutoMapper;
using ERPTP.Dtos;
using ERPTP.Models;

namespace ERPTP.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}