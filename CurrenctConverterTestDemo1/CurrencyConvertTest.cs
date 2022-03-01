using CurrencyConverter;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using Xunit;

namespace CurrencyConverterTestDemo1
{
    public class CurrencyConvertTest
    {
        private readonly IAllConversionsRepository _allConversions;
        private readonly IUnknown _unknown;
        private readonly CurrencyCalculator _convert;
        private readonly InputValidator _inputValidator;

        public CurrencyConvertTest()
        {
            _allConversions = Substitute.For<IAllConversionsRepository>();
            _unknown = Substitute.For<IUnknown>();
            _convert = new CurrencyCalculator(_allConversions, _unknown);
            _inputValidator = new InputValidator();
        }

        [Theory]
        [InlineData("EUR", "DKK", 1)]
        public void CheckExchangedAmountIsNotMatching(string currency1,string currency2,decimal amount)
        {
          
            _allConversions.GetConversionRates().Returns(new System.Collections.Generic.Dictionary<string, decimal>
                    {
                        {"EUR", 7.4394m },
                        {"DKK",1 }
                    });
            _unknown.IsUnknown("EUR").Returns(false);
            _unknown.IsUnknown("DKK").Returns(false);

            decimal expected = 12 ;
            decimal actual = _convert.Calculate(currency1,currency2,1);
            Assert.NotEqual(expected, actual);
        }

        [Theory]
        [InlineData("EUR", "DKK", 1)]
        public void CheckExchangedAmountIsMatching(string currency1, string currency2, decimal amount)
        {
            decimal expected = 7.4394m;
            _allConversions.GetConversionRates().Returns(new System.Collections.Generic.Dictionary<string, decimal>
            {
                {"EUR", 7.4394m },
                {"DKK",1 }
            });
            _unknown.IsUnknown(currency1).Returns(false);
            _unknown.IsUnknown(currency2).Returns(false);

  
            var actual = _convert.Calculate(currency1, currency2, amount);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-10.9)]
        [InlineData(-0.0009)]
        public void CheckInValidAmount(decimal amount)
        {
           
            Assert.Throws<System.Exception>(() => _inputValidator.Validate(amount));
        }

        [Theory]
        [InlineData("EUR", "DNN", 1)]
        [InlineData("GBR", "USD", 22)]
        public void CheckUnknownTypeCurrencyInvalid(string currency1, string currency2, decimal amount)
        {
            _allConversions.GetConversionRates().Returns(new System.Collections.Generic.Dictionary<string, decimal> {
            {"EUR", 7.4394m }});

            _unknown.IsUnknown(currency1).Returns(true);

            Assert.Throws<System.Exception>(() => _convert.Calculate(currency1, currency2, amount));
        }

        [Fact]
        public void OutputTest()
        {
            ICalculate calculate = Substitute.For<ICalculate>();
            Output output = new Output(calculate);
            calculate.Calculate("EUR", "DKK", 1).Returns(7.4394m);

        }
    }
}