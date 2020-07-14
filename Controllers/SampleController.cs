using System;
using Microsoft.AspNetCore.Mvc;
namespace MyProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase

    {
        string[] cars = { "lambo", "BMW", "Aventador" };
        public SampleController()
        {

        }
        [HttpGet]
        public string[] Get() {
            return cars;
        }

    }
}
