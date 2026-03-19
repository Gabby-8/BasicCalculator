using BasicCalculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasicCalculator.Controllers
{
    [ApiController]
    [Route("api/calculator")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService service;

        public CalculatorController(ICalculatorService _service)
        {
            service = _service;
        }

        [HttpGet("add")]
        public IActionResult Add(double x, double y)
        {
            return Ok(service.Add(x, y));
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double x, double y)
        {
            return Ok(x - y);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double x, double y)
        {
            return Ok(x * y);
        }

        [HttpGet("divide")]
        public IActionResult Divide(double x, double y)
        {
            if(y == 0)
            {
                return BadRequest("Cannot divide by zero.");
            }

            return Ok(x / y);
        }
    }
}
