using CurrencyConverter;
using NSubstitute;
using Xunit;

namespace CurrenctConverterTestDemo1
{
    public class CurrencyConvertTest
    {
        private IAllConversionsRepository allConversions;
        private IUnknown unknown;
        private InputValidator inputValidator;
        private CurrencyCalculator convert;

        public CurrencyConvertTest()
        {
            allConversions = Substitute.For<IAllConversionsRepository>();
            unknown = Substitute.For<IUnknown>();
            convert = new CurrencyCalculator(allConversions, unknown);
        }

        [Theory]
        [InlineData("EUR", "DKK", 1)]
        public void CheckExchangedAmountIsNotMatching(string currency1,string currency2,decimal amount)
        {
          
            allConversions.GetConversionRates().Returns(new System.Collections.Generic.Dictionary<string, decimal>
                    {
                        {"EUR", 7.4394m },
                        {"DKK",1 }
                    });
            unknown.IsUnknown("EUR").Returns(false);
            unknown.IsUnknown("DKK").Returns(false);

            decimal expected = 12 ;
            decimal actual = convert.Calculate(currency1,currency2,1);
            Assert.NotEqual(expected, actual);
        }

        [Theory]
        [InlineData("EUR", "DKK", 1)]
        public void CheckExchangedAmountIsMatching(string currency1, string currency2, decimal amount)
        {
            decimal expected = 7.4394m;
            allConversions.GetConversionRates().Returns(new System.Collections.Generic.Dictionary<string, decimal>
            {
                {"EUR", 7.4394m },
                {"DKK",1 }
            });
            unknown.IsUnknown(currency1).Returns(false);
            unknown.IsUnknown(currency2).Returns(false);

  
            var actual = convert.Calculate(currency1, currency2, amount);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-10.9)]
        [InlineData(-0.0009)]
        public void CheckInValidAmount(decimal amount)
        {
            inputValidator = new InputValidator();
            Assert.Throws<System.Exception>(() => inputValidator.Validate(amount));
        }

        [Theory]
        [InlineData("EUR", "DNN", 1)]
        [InlineData("GBR", "USD", 22)]
        public void CheckUnknownTypeCurrencyInvalid(string currency1, string currency2, decimal amount)
        {
            allConversions.GetConversionRates().Returns(new System.Collections.Generic.Dictionary<string, decimal> {
            {"EUR", 7.4394m }});

            unknown.IsUnknown(currency1).Returns(true);
            convert = new CurrencyCalculator(allConversions, unknown);

            Assert.Throws<System.Exception>(() => convert.Calculate(currency1, currency2, amount));
        }
    }
}