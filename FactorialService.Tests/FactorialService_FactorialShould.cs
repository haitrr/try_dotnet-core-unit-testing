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

        [Fact]
        public void TestFactorialOfNumberLessThan10()
        {
            Assert.Equal(_factorialService.Factorial(2), 2);
            Assert.Equal(_factorialService.Factorial(3), 6);
            Assert.Equal(_factorialService.Factorial(6), 720);
            Assert.Equal(_factorialService.Factorial(7), 5040);
            Assert.Equal(_factorialService.Factorial(9), 362880);
        }

        [Fact]
        public void TestWithNegativeNumber()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(-9999, -1);
                Assert.Throws<NotSupportedException>(() => _factorialService.Factorial(number));
            }
        }
    }
}
