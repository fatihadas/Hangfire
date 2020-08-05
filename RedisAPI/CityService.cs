using System.Collections.Generic;

namespace RedisAPI
{
    public class CityService
    {
        public static IEnumerable<City> GetCities(string countryId)
        {
            return new List<City>
            {
                new City() { CityId = "01", CityName = "Adana" },
                new City() { CityId = "06", CityName = "Ankara" },
                new City() { CityId = "34", CityName = "İstanbul" },
                new City() { CityId = "35", CityName = "İzmir" }
            };
        }
    }
}
