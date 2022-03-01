namespace CurrencyConverter
{
    public class Solution
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Exchange");
            Rates rates = new Rates();
            InputProcessor inputProcessor = new InputProcessor();
            InputValidator validator = new InputValidator();
            InvalidCurrency checkInvalid = new InvalidCurrency(rates);
            CurrencyCalculator currencyConvert = new CurrencyCalculator(rates, checkInvalid);
            Inputs userInput = inputProcessor.Capture();
            validator.Validate(userInput.Amount);
            Output output = new Output(currencyConvert);
            decimal exchangedAmount = output.Result(userInput.Currency1, userInput.Currency2, userInput.Amount);
            Console.WriteLine(exchangedAmount);
        }
    }
}