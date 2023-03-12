using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class CityProfile
    {
        public CityProfile() 
        {
                CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
        }
    }
}
