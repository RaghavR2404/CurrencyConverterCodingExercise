using System;
namespace CurrencyConverter
{
    public interface IAllConversions
    {
        public Dictionary<string, decimal> ConversionRates();
    }
}
