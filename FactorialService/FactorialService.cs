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
            return Factorial(number - 1) * number;
        }
    }
}
