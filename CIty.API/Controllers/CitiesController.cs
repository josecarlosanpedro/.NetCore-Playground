using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIty.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            var result = Json(CitiesDataStore.Current.Cities);
            result.StatusCode = 200;
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var result = Json(
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id)
            );
            result.StatusCode = 200;
            if (result == null) {
                return NotFound();
            }
            return Ok(result);
        }
    }
}