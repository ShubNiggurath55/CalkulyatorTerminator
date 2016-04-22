using System.Runtime.ExceptionServices;

namespace ForCalkEg
{
    public class Sum:ICalculator
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return firstArg + secondArg;
        }
    }
}