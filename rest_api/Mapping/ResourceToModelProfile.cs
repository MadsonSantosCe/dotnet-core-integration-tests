using rest_api.Domain.Models;
using rest_api.Resources;
using AutoMapper;

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
