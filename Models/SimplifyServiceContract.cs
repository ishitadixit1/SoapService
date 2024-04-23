using System.ServiceModel;

namespace SoapService.Models
{
    public class SimplifyServiceContract
    {
        [ServiceContract]
        public interface InterfaceSimplifier
        {
            // Operation contract to set the numbers for calculation
            [OperationContract]
            void SetNumbers(double number1, double number2);

            // Operation contract for add, sub, multiply, divide
            [OperationContract]
            double DoAddition(double number1, double number2);

            [OperationContract]
            double DoSubtraction(double number1, double number2);

            [OperationContract]
            double DoMultiplication(double number1, double number2);

            [OperationContract]
            double DoDivision(double number1, double number2);


        }
    }
}
