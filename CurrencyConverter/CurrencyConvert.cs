using System;

namespace CurrencyConverter
{
    public class CurrencyConvert : ICalculate
    {
        IAllConversions rates;
        IUnknown checkInvalid;


        public CurrencyConvert(IAllConversions _rates, IUnknown _checkInvalid)
        {
            rates = _rates;
            checkInvalid = _checkInvalid;
        } 
        public decimal Calculate(string currency1, string currency2, decimal amount)
        {
            
            var curr = rates.ConversionRates();
            // if any one currency is unknown throw an exception
            if (checkInvalid.IsUnknown(currency1) || checkInvalid.IsUnknown(currency2))
                throw new Exception("Unknown Currency");
            // if both currency are same just return amount
            if (currency1.Equals(currency2)) return amount;
            // actual caculation to convert 
            curr.TryGetValue(currency1, out var ex1);
            curr.TryGetValue(currency2, out var ex2);

            decimal exchange = (ex1 * amount) / ex2;

            return exchange;
        }
    }
}
