using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
//using static SoapService.Models.SimplifyServiceContract;

namespace SoapService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimplificationController : ControllerBase
    {
        [HttpGet("{firstno:double} + {secondno:double}")]
        public async Task<double> DoAdditionAsync(double firstno, double secondno)
        {
            InterfaceSimplifier calc = new InterfaceSimplifierClient(InterfaceSimplifierClient.EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
            return await calc.DoAdditionAsync(firstno, secondno);
        }

        [HttpGet("{firstno:double} - {secondno:double}")]
        public async Task<double> DoSubtractionAsync(double firstno, double secondno)
        {
            InterfaceSimplifier calc = new InterfaceSimplifierClient(InterfaceSimplifierClient.EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
            return await calc.DoSubtractionAsync(firstno, secondno);
        }

        [HttpGet("{firstno:double} * {secondno:double}")]
        public async Task<double> DoMultiplicationAsync(double firstno, double secondno)
        {
            InterfaceSimplifier calc = new InterfaceSimplifierClient(InterfaceSimplifierClient.EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
            return await calc.DoMultiplicationAsync(firstno, secondno);
        }

        [HttpGet("{firstno:double} / {secondno:double}")]
        public async Task<IActionResult> DoDivisionAsync(double firstno, double secondno)
        {
            if (secondno == 0)
            {
                return StatusCode(400, "Bad Request: Division by zero is not allowed.");
            }

            try
            {
                InterfaceSimplifier calc = new InterfaceSimplifierClient(InterfaceSimplifierClient.EndpointConfiguration.BasicHttpBinding_InterfaceSimplifier);
                double result = await calc.DoDivisionAsync(firstno, secondno);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Cannot divide by 0");
            }
        }
    }
}
