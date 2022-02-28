using CurrencyConverter;
using Xunit;

namespace CurrenctConverterTestDemo1
{
    public class RatesTest : IClassFixture<Rates>
    {
        private Rates rates;

        public RatesTest(Rates _rates)
        {
            rates = _rates;
        }

        [Fact]
        public void CheckCurrencyPairs()
        {
            int min = 0;
            Assert.True(rates.GetConversionRates().Count > min);
        }
    }
}