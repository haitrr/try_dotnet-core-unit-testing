using System;

namespace Factorial.Services
{
    public class FactorialService
    {
        public int Factorial(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            throw new NotImplementedException("This case is not implemented");
        }
    }
}
