using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPlain.Dtos;
using WestPlain.Models;

namespace WestPlain.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            Mapper.CreateMap<Register, RegisterDto>();
            Mapper.CreateMap<Contact, ContactDto>();
            Mapper.CreateMap<BusinessType, BusinessTypeDto>();
            Mapper.CreateMap<Newsletter, NewsletterDto>();
            //Dto to Domain
            Mapper.CreateMap<RegisterDto, Register>();
            Mapper.CreateMap<ContactDto, Contact>();
            Mapper.CreateMap<NewsletterDto, Newsletter>();

        }
    }
}