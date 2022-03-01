namespace CurrencyConverter
{
    public class Output
    {
        private readonly  ICalculate _currencyConvert;

        public Output(ICalculate currencyConvert)
        {
            _currencyConvert = currencyConvert;
        }
        public decimal Result(string currency1, string currency2, decimal amount)
        {
            decimal exchangedAmount = 0;
            try
            {
                exchangedAmount = _currencyConvert.Calculate(currency1, currency2, amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return exchangedAmount;
        }
    }
}