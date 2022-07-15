using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BillyGYM.Domain.Entities;
using BillyGYM.Infrastucture.ViewModel;

namespace BillyGYM.Infrastucture.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, Customer>()
                .ForMember(Dest => Dest.Id,
                opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}
