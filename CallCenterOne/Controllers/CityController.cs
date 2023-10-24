using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CallCenterOne.Interfaces;
using CallCenterOne.Services;

namespace CallCenterOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public IActionResult GetCities()
        {
            var cities = _cityService.GetAllCities();

            if (!ModelState.IsValid) 
            { 
                return BadRequest(ModelState);
            }

            return Ok(cities);
        }

        [HttpGet("{cityId}")]
        public IActionResult GetCity(int cityId)
        {
            if (cityId == 0)
            {
                return BadRequest("Id required");
            }

            if (!_cityService.CityExists(cityId))
                return NotFound();

            var city = _cityService.GetCityById(cityId);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(city);
        }


    }
}
