using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using System;
using System.ServiceModel;

namespace SoapService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimplificationController : ControllerBase
    {
        [HttpGet("add")]
        public async Task<double> DoAdditionAsync(double firstno, double secondno)
        {
            InterfaceSimplifier calc = new InterfaceSimplifierClient(InterfaceSimplifierClient.EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
            return await calc.DoAdditionAsync(firstno, secondno);
        }

        [HttpGet("subtract")]
        public async Task<double> DoSubtractionAsync(double firstno, double secondno)
        {
            InterfaceSimplifier calc = new InterfaceSimplifierClient(InterfaceSimplifierClient.EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
            return await calc.DoSubtractionAsync(firstno, secondno);
        }

        [HttpGet("multiply")]
        public async Task<double> DoMultiplicationAsync(double firstno, double secondno)
        {
            InterfaceSimplifier calc = new InterfaceSimplifierClient(InterfaceSimplifierClient.EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
            return await calc.DoMultiplicationAsync(firstno, secondno);
        }

        [HttpGet("divide")]
        public async Task<IActionResult> CalculateDivisionAsync(double number1, double number2)
        {
            if (number2 == 0)
            {
                return StatusCode(400, "Bad Request: Division by zero is not allowed.");
            }

            try
            {
                InterfaceSimplifier calc = new InterfaceSimplifierClient(InterfaceSimplifierClient.EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
                double result = await calc.DoDivisionAsync(number1, number2);
                return Ok(result);
            }
            catch (DivideByZeroException)
            {
                return StatusCode(400, "Bad Request: Division by zero is not allowed.");
            }           
            catch (Exception)
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }
    }
}
