namespace CurrencyConverter
{
    public class InputProcessor
    {
        public Inputs Capture()
        {
            Inputs inputs = new Inputs();
            Console.WriteLine("Enter 1st Currency");
            inputs.Currency1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd Currency");
            inputs.Currency2 = Console.ReadLine();
            Console.WriteLine("Enter the Amount");
            inputs.Amount = Decimal.Parse(Console.ReadLine());
            return inputs;
        }
    }
}