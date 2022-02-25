using CurrencyConverter;
using Xunit;
namespace CurrenctConverterTestDemo1
{
    public class CurrencyConvertTest
    {

        CurrencyConvert convert = new CurrencyConvert(new Rates(), new CheckInvalid(new Rates()));
        [Fact]
        public void CheckExchangedAmount1()
        {
            //fail
            decimal expected = 12m;
            decimal actual = convert.Calculate("EUR", "DKK", 1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CheckExchangedAmount2()
        {
            //pass
            decimal expected = 7.4394m;
            decimal actual = convert.Calculate("EUR", "DKK", 1);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(-10)]
        [InlineData(19)]
        public void CheckValidAmount(decimal amount)
        {
            Assert.True(amount > 0);
        }


        [Theory]
        [InlineData("EUR","DNN",1)]
        public void CheckUnknownTypeCurrency1(string currency1,string currency2,decimal amount)
        {
            Assert.Throws<System.Exception>(() =>  convert.Calculate(currency1, currency2, amount));
        }
        [Theory]
        [InlineData("EUR", "USD", 11)]
        public void CheckUnknownTypeCurrency2(string currency1, string currency2, decimal amount)
        {
            Assert.Throws<System.Exception>(() => convert.Calculate(currency1, currency2, amount));
        }
    }
}