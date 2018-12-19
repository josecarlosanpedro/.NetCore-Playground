using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIty.API.Models;
namespace CIty.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current {get;} = new CitiesDataStore();
        public List<CityDto> Cities {get; set;}

        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "One with Big Park"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "One with Cathedral"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "One with Tower"
                }
            };
        }
    }
}