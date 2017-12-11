using System;
using Xunit;
using Factorial.Services;
namespace Factorial.UnitTests.Services
{
    public class FactorialService_FactorialShould
    {
        private readonly FactorialService _factorialService;
        public FactorialService_FactorialShould()
        {
            _factorialService = new FactorialService();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Return1IfGivenNumberLessThan2(int number)
        {
            int result = _factorialService.Factorial(number);
            Assert.Equal(result, 1);
        }
    }
}
