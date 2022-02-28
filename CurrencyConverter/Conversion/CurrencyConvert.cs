<<<<<<< HEAD
﻿namespace CurrencyConverter
{
    public class CurrencyConvert : ICalculate
    {
        private IAllConversionsRepository _rates;
        private IUnknown _checkInvalid;
=======
﻿using System;

namespace CurrencyConverter
{
    public class CurrencyConvert : ICalculate
    {
       private IAllConversionsRepository _rates;
       private IUnknown _checkInvalid;

>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040

        public CurrencyConvert(IAllConversionsRepository rates, IUnknown checkInvalid)
        {
            _rates = rates;
            _checkInvalid = checkInvalid;
<<<<<<< HEAD
        }

        public decimal Calculate(string currency1, string currency2, decimal amount)
        {
=======
        } 
        public decimal Calculate(string currency1, string currency2, decimal amount)
        {
            
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
            var curr = _rates.GetConversionRates();
            // if any one currency is unknown throw an exception
            if (_checkInvalid.IsUnknown(currency1) || _checkInvalid.IsUnknown(currency2))
                throw new Exception("Unknown Currency");
            // if both currency are same just return amount
            if (currency1.Equals(currency2)) return amount;
<<<<<<< HEAD
            // actual caculation to convert
=======
            // actual caculation to convert 
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
            curr.TryGetValue(currency1, out var exchangerateInDkk1);
            curr.TryGetValue(currency2, out var exchangeRateinDkk2);

            decimal exchangeResult = (exchangerateInDkk1 * amount) / exchangeRateinDkk2;
<<<<<<< HEAD
            exchangeResult = Decimal.Round(exchangeResult,4);
            return exchangeResult;
        }
    }
}
=======
            exchangeResult = Math.Round(exchangeResult, 4);
            return exchangeResult;
        }
    }
}
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
