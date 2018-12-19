using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIty.API.Controllers
{
    public class CitiesController : Controller
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities(){
        return new JsonResult(new List<object>() {
            new { id=1, Name="New York"},
            new { id=2, Name="AntWerp"}
        });
        }
    }
}