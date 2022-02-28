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
            CheckInvalid checkInvalid = new CheckInvalid(rates);
            CurrencyConvert currencyConvert = new CurrencyConvert(rates, checkInvalid);
            Inputs userInput = inputProcessor.Capture();
            validator.Validate(userInput.Amount);
            Output output = new Output(currencyConvert);
            decimal exchangedAmount = output.Result(userInput.Currency1, userInput.Currency2, userInput.Amount);
            Console.WriteLine(exchangedAmount);
        }
    }
}