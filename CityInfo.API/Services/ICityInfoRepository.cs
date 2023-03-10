using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public class ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAync();
    }
}
