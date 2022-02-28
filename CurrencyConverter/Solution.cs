namespace CurrencyConverter
<<<<<<< HEAD
{
=======
{ 
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
    public class Solution
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Exchange");
            Rates rates = new Rates();
<<<<<<< HEAD
            InputProcessor inputProcessor = new InputProcessor();
            InputValidator validator = new InputValidator();
            CheckInvalid checkInvalid = new CheckInvalid(rates);
            CurrencyConvert currencyConvert = new CurrencyConvert(rates, checkInvalid);
=======
            InputProcessor inputProcessor = new InputProcessor();   
            InputValidator validator = new InputValidator();
            CheckInvalid checkInvalid = new CheckInvalid(rates);
            CurrencyConvert currencyConvert = new CurrencyConvert(rates,checkInvalid);
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
            Inputs userInput = inputProcessor.Capture();
            validator.Validate(userInput.Amount);
            Output output = new Output(currencyConvert);
            decimal exchangedAmount = output.Result(userInput.Currency1, userInput.Currency2, userInput.Amount);
            Console.WriteLine(exchangedAmount);
        }
    }
}