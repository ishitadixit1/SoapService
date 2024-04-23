using SoapService.Models;
using static SoapService.Models.SimplifyServiceContract;
//using static SoapService.Controllers.SimplificationController;
namespace SoapService.Services
{
    public class SimplifyService : InterfaceSimplifier
    {
        public void SetNumbers(double n1, double n2)
        {
            SimplifyDataContract obj = new SimplifyDataContract
            {
                firstno = n1,
                secondno = n2,
                Result = 0
            };
        }

        public double DoAddition(double firstno, double secondno)
        {
            var result = firstno + secondno;
            return result;
        }

        public double DoSubtraction(double firstno, double secondno)
        {
            var result = firstno - secondno;
            return result;
        }

        public double DoMultiplication(double firstno, double secondno)
        {

            var result = firstno * secondno;
            return result;
        }

        public double DoDivision(double firstno, double secondno)
        {
            var result = firstno / secondno;
            return result;
        }
    }
}
