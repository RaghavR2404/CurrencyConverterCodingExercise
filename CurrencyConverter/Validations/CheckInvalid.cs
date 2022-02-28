namespace CurrencyConverter
{
    public class CheckInvalid : IUnknown
    {
        private IAllConversionsRepository _rates;

        public CheckInvalid(IAllConversionsRepository rates)
        {
            _rates = rates;
        }

        public bool IsUnknown(string currency)
        {
            return !(_rates.GetConversionRates().ContainsKey(currency));
        }
    }
}