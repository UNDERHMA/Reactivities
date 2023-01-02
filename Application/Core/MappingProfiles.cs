
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>(); //maps JSON in request to Activity object based on field names
        }
    }
}