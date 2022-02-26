using CurrencyConverter;
using Xunit;
using NSubstitute;
namespace CurrenctConverterTestDemo1
{
    public class CurrencyConvertTest
    {
        IAllConversions allConversions;
        IUnknown unknown;
        CurrencyConvert convert;
        public CurrencyConvertTest()
            {
            allConversions = new Rates();
            unknown = new CheckInvalid(allConversions);
            convert = new CurrencyConvert(allConversions,unknown);
            }
          [Theory]
          [MemberData(nameof(Expected.ExpectedValue1),MemberType =typeof(Expected))]
        public void CheckExchangedAmountIsNotMatching(string currency1,string currency2,decimal amount,decimal expected)
        {
            decimal actual = convert.Calculate(currency1, currency2,amount);
            Assert.NotEqual(expected, actual);
        }
        [Theory]
        [MemberData(nameof(Expected.ExpectedValue2), MemberType = typeof(Expected))]
        public void CheckExchangedAmountIsMatching(string currency1, string currency2, decimal amount, decimal expected)
        {
            decimal actual =  convert.Calculate(currency1,currency2,amount);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(19.0)]
        [InlineData(12.0)]
        public void CheckValidAmount(decimal amount)
        {
            Assert.True(amount > 0);
        }
        [Theory]
        [InlineData(-10.0)]
        [InlineData(-12.0)]   
        public void CheckInValidAmount(decimal amount)
        {
            Assert.False(amount > 0);
        }


        [Theory]
        [InlineData("EUR","DNN",1)]
        [InlineData("GBR","USD",22)]
        public void CheckUnknownTypeCurrencyInvalid(string currency1,string currency2,decimal amount)
        {
            Assert.Throws<System.Exception>(() =>  convert.Calculate(currency1, currency2, amount));
        }
        [Theory]
        [InlineData("EUR", "USD", 11)]
        public void CheckUnknownTypeCurrencyValid(string currency1, string currency2, decimal amount)
        {
           var ex =convert.Calculate(currency1, currency2, amount);
           Assert.IsNotType<System.Exception>(() => ex);
        }
    }
}