namespace CurrencyConverter
{
    public class CurrencyCalculator : ICalculate
    {
        private IAllConversionsRepository _rates;
        private IUnknown _checkInvalid;

        public CurrencyCalculator(IAllConversionsRepository rates, IUnknown checkInvalid)
        {
            _rates = rates;
            _checkInvalid = checkInvalid;
        }

        public decimal Calculate(string currency1, string currency2, decimal amount)
        {
            var curr = _rates.GetConversionRates();
            // if any one currency is unknown throw an exception
            if (_checkInvalid.IsUnknown(currency1) || _checkInvalid.IsUnknown(currency2))
                throw new Exception("Unknown Currency");
            // if both currency are same just return amount
            if (currency1.Equals(currency2)) return amount;
            // actual caculation to convert
            curr.TryGetValue(currency1, out var exchangerateInDkk1);
            curr.TryGetValue(currency2, out var exchangeRateinDkk2);

            decimal exchangeResult = (exchangerateInDkk1 * amount) / exchangeRateinDkk2;
            exchangeResult = Decimal.Round(exchangeResult,4);
            return exchangeResult;
        }
    }
}