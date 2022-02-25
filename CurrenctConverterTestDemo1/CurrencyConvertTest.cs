using CurrencyConverter;
using Xunit;
namespace CurrenctConverterTestDemo1
{
    public class CurrencyConvertTest
    {

        CurrencyConvert convert = new CurrencyConvert(new Rates(), new CheckInvalid(new Rates()));
        [Fact]
        public void CheckExchangedAmountIsNotMatching()
        {
            //fail
            decimal expected = 12m;
            decimal actual = convert.Calculate("EUR", "DKK", 1);
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void CheckExchangedAmountIsMatching()
        {
            //pass
            decimal expected = 7.4394m;
            decimal actual = convert.Calculate("EUR", "DKK", 1);
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
        public void CheckUnknownTypeCurrency1(string currency1,string currency2,decimal amount)
        {
            Assert.Throws<System.Exception>(() =>  convert.Calculate(currency1, currency2, amount));
        }
        [Theory]
        [InlineData("EUR", "USD", 11)]
        public void CheckUnknownTypeCurrency2(string currency1, string currency2, decimal amount)
        {
           var ex =convert.Calculate(currency1, currency2, amount);
           Assert.IsNotType<System.Exception>(() => ex);
        }
    }
}