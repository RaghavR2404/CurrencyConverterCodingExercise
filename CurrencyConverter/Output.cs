using System;


namespace CurrencyConverter
{
    public class Output
    {
        CurrencyConvert currencyConvert;
       public Output(CurrencyConvert _currencyConvert)
        {
            currencyConvert = _currencyConvert;
        }
        public  decimal Result(string Currency1, string Currency2, decimal amount)
        {
            decimal exchangedAmount = 0;
            try
            {
                exchangedAmount = currencyConvert.Calculate(Currency1, Currency2, amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return exchangedAmount;
        }
    }

}