using CurrencyConverter;
using NSubstitute;
using Xunit;

namespace CurrenctConverterTestDemo1
{
    public class CurrencyConvertTest
    {
<<<<<<< HEAD
=======


>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
        /*  IAllConversions conversions = Substitute.For<IAllConversions>();
          IUnknown unknown = Substitute.For<IUnknown>();
          CurrencyConvert convert;
          public CurrencyConvertTest()
          {
              convert = new CurrencyConvert(conversions,unknown);
<<<<<<< HEAD
          }
        */

        private IAllConversionsRepository allConversions;
        private IUnknown unknown;
        private InputValidator inputValidator;
        private CurrencyConvert convert;

=======

          }
        */

        IAllConversionsRepository allConversions;
        IUnknown unknown;
        CurrencyConvert convert;
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
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
<<<<<<< HEAD
                {"EUR", 7.4394m },
                {"DKK",1 }
            });
            unknown.IsUnknown(currency1).Returns(false);
            unknown.IsUnknown(currency2).Returns(false);

            convert = new CurrencyConvert(allConversions,unknown);
            var actual = convert.Calculate(currency1, currency2, amount);
=======
            allConversions = Substitute.For<IAllConversionsRepository>(); 
            unknown = new CheckInvalid(allConversions);
            convert = new CurrencyConvert(allConversions,unknown);
            }
     
          [Theory]
          [MemberData(nameof(Expected.ExpectedValue1),MemberType =typeof(Expected))]
        public void CheckExchangedAmountIsNotMatching(string currency1,string currency2,decimal amount,decimal expected)
        {
            allConversions.GetConversionRates().Returns(new System.Collections.Generic.Dictionary<string, decimal>
            {
                {"EUR",12m }
            });

            decimal actual = convert.Calculate(currency1, currency2,amount);
            Assert.NotEqual(expected, actual);
        }
        [Theory]
        [MemberData(nameof(Expected.ExpectedValue2), MemberType = typeof(Expected))]
        public void CheckExchangedAmountIsMatching(string currency1, string currency2, decimal amount, decimal expected)
        {
            decimal actual =  convert.Calculate(currency1,currency2,amount);
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
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