

using Delegates1.Services;

namespace Delegates1
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            double y = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(x,y);
            Console.WriteLine(result);  
        }
    }
}