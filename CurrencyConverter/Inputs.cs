using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Inputs
    {
        public string Currency1 { get; set; }
        public string Currency2 { get; set; }
        public decimal Amount { get; set; }
    }

    class InputCapture
    {
        public static Inputs Capture()
        {
            Inputs inputs = new Inputs();
            Console.WriteLine("Enter 1st Currency");
            inputs.Currency1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd Currency");
            inputs.Currency2 = Console.ReadLine();
            Console.WriteLine("Enter the Amount");
            try
            {
                inputs.Amount = decimal.Parse(Console.ReadLine());
                if (inputs.Amount <= 0) throw new Exception("Invalid Amount");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return inputs;
        }
    }
}
