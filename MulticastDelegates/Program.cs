
using MulticastDelegates.Services;

class Program
{

    delegate void BinaryNumericOperation(double n1, double n2);

    static void Main(string[] args)
    {
        double a = 2, b = 3;

        BinaryNumericOperation op = CalculationService.ShowSum;
        op += CalculationService.ShowMax;

        op.Invoke(a, b);
    }
}