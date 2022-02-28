<<<<<<< HEAD
﻿namespace CurrencyConverter
=======
﻿using System;

namespace CurrencyConverter
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
{
    public class Rates : IAllConversionsRepository
    {
        //key value pair for 1 unit of each curr and equivalent amount in Dkk
        public Dictionary<string, decimal> GetConversionRates()
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