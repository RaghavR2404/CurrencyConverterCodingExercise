namespace CurrencyConverter
{
    public interface ICalculate
    {
        public decimal Calculate(string currency1, string currency2, decimal amount);
    }
}