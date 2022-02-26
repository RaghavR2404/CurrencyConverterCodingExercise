﻿using System;

namespace CurrencyConverter
{
    public class CheckInvalid : IUnknown
    { 
        IAllConversions rates;
       public CheckInvalid(IAllConversions _rates)
        {
            rates = _rates;
        }
        public bool IsUnknown(string currency)
        {
            return !(rates.ConversionRates().ContainsKey(currency));
        }
    }

}
