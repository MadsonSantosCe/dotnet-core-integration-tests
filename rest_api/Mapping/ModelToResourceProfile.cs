using AutoMapper;
using rest_api.Domain.Models;
using rest_api.Resources;

namespace rest_api.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
