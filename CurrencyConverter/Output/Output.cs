<<<<<<< HEAD
﻿namespace CurrencyConverter
{
    public class Output
    {
        private CurrencyConvert _currencyConvert;

        public Output(CurrencyConvert currencyConvert)
        {
            _currencyConvert = currencyConvert;
        }

        public decimal Result(string Currency1, string Currency2, decimal amount)
=======
﻿using System;
namespace CurrencyConverter
{
    public class Output
    {
        CurrencyConvert _currencyConvert;
       public Output(CurrencyConvert currencyConvert)
        {
            _currencyConvert = currencyConvert;
        }
        public  decimal Result(string Currency1, string Currency2, decimal amount)
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
        {
            decimal exchangedAmount = 0;
            try
            {
                exchangedAmount = _currencyConvert.Calculate(Currency1, Currency2, amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return exchangedAmount;
        }
    }
<<<<<<< HEAD
=======

>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
}