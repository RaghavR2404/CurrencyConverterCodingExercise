using CurrencyConverter;
using NSubstitute;
using Xunit;

namespace CurrenctConverterTestDemo1
{
    public class CurrencyConvertTest
    {
        /*  IAllConversions conversions = Substitute.For<IAllConversions>();
          IUnknown unknown = Substitute.For<IUnknown>();
          CurrencyConvert convert;
          public CurrencyConvertTest()
          {
              convert = new CurrencyConvert(conversions,unknown);
          }
        */

        private IAllConversionsRepository allConversions;
        private IUnknown unknown;
        private InputValidator inputValidator;
        private CurrencyConvert convert;

        public CurrencyConvertTest()
        {
            
            allConversions = Substitute.For<IAllConversionsRepository>();
            unknown = Substitute.For<IUnknown>();
            convert = new CurrencyConvert(allConversions, unknown);
        }
        /*
                [Theory]
                
                [Fact]
                public void CheckExchangedAmountIsNotMatching()
                {
                    allConversions.GetConversionRates().Returns(new System.Collections.Generic.Dictionary<string, decimal>
                    {
                        {"EUR", 7.4394m }
                    });
                    unknown.IsUnknown("EUR").Returns(false);
                    var expected = ;
                    decimal actual = convert.Calculate("EUR", "DKK", 7.434m);
                    Assert.NotEqual(expected, actual);
                }
        */
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

            convert = new CurrencyConvert(allConversions,unknown);
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
            convert = new CurrencyConvert(allConversions, unknown);

            Assert.Throws<System.Exception>(() => convert.Calculate(currency1, currency2, amount));
        }
    }
}