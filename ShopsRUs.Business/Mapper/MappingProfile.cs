using AutoMapper;
using ShopsRUs.Model;
using ShopsRUs.Model.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Business.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();

            CreateMap<Invoice, InvoiceDto>();
            CreateMap<InvoiceDto, Invoice>();

            CreateMap<UserCategoryDto, UserCategory>();
            CreateMap<UserCategory, UserCategoryDto>();

        }
        
    }
}
