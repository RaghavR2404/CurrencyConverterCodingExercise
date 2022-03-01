namespace CurrencyConverter
{
    public class InvalidCurrency : IUnknown
    {
        private IAllConversionsRepository _rates;

        public InvalidCurrency(IAllConversionsRepository rates)
        {
            _rates = rates;
        }

        public bool IsUnknown(string currency)
        {
            return !(_rates.GetConversionRates().ContainsKey(currency));
        }
    }
}