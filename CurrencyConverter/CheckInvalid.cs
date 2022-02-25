using System;

namespace CurrencyConverter
{
    public class CheckInvalid : IUnknown
    {
        Rates rates;
       public CheckInvalid(Rates _rates)
        {
            rates = _rates;
        }
        public bool IsUnknown(string currency)
        {
            return !(rates.ConversionRates().ContainsKey(currency));
        }
    }

}
