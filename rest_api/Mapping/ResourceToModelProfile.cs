using rest_api.Domain.Models;
using rest_api.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api.Mapping
{
    public class ResourceToModelProfile : Profile
    {

        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }

    }
}
