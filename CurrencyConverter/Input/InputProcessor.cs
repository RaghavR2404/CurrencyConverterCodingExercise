<<<<<<< HEAD
﻿namespace CurrencyConverter
{
    public class InputProcessor
    {
        public Inputs Capture()
=======
﻿using System;

namespace CurrencyConverter
{
   public class InputProcessor
    {
        public  Inputs Capture()
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
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
<<<<<<< HEAD
}
=======
}
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
