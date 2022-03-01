namespace CurrencyConverter
{
    public class Output
    {
        private CurrencyCalculator _currencyConvert;

        public Output(CurrencyCalculator currencyConvert)
        {
            _currencyConvert = currencyConvert;
        }
        public decimal Result(string Currency1, string Currency2, decimal amount)
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
}