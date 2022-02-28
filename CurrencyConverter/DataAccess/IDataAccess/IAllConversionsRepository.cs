using System;
namespace CurrencyConverter
{
    public interface IAllConversionsRepository
    {
        public Dictionary<string, decimal> GetConversionRates();
    }
}
