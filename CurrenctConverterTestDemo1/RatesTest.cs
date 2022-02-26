using CurrencyConverter;
using System;
using Xunit;
using NSubstitute;
namespace CurrenctConverterTestDemo1
{
    public class RatesTest:IClassFixture<Rates>
    {
        Rates rates;
        public RatesTest(Rates _rates)
        {
            rates = _rates;
        }
        [Fact]
        public void CheckCurrencyPairs()
        {
            int min = 0;
            Assert.True(rates.ConversionRates().Count > min);
        }
    }
}
