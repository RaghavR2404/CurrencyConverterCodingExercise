namespace CurrencyConverter
{
    public class InputValidator : IInputValidator
    {
        public void Validate(decimal amount)
        {
           
                if (amount <= 0)
                    throw new Exception("Invalid Amount");
           
            
        }
    }
}