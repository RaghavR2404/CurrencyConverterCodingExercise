using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Rates : IAllConversions
    {
     

        //key value pair for 1 unit of each curr and equivalent amount in Dkk
        public Dictionary<string, decimal> ConversionRates()
        {
            var conversionRatesInDkk = new Dictionary<String, decimal>();
           
            conversionRatesInDkk.Add("EUR", 7.4394m);
            conversionRatesInDkk.Add("USD", 6.631m);
            conversionRatesInDkk.Add("GBP", 8.528m);
            conversionRatesInDkk.Add("SEK", 0.761m);
            conversionRatesInDkk.Add("NOK", 0.784m);
            conversionRatesInDkk.Add("CHF", 6.835m);
            conversionRatesInDkk.Add("JPY", 0.05974m);
            conversionRatesInDkk.Add("DKK", 1);

            return conversionRatesInDkk;

        }
    }
}
