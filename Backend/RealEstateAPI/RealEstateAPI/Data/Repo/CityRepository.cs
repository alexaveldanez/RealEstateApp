using Microsoft.EntityFrameworkCore;
using RealEstateAPI.Interfaces;
using RealEstateAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateAPI.Data.Repo
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _dc;
        public CityRepository(DataContext dc)
        {
            _dc = dc;
        }

        public void AddCity(City city)
        {
            _dc.Cities.Add(city);
        }

        public void DeleteCity(int cityId)
        {
            var city = _dc.Cities.Find(cityId);
            _dc.Cities.Remove(city);
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _dc.Cities.ToListAsync();
        }

    }
}
