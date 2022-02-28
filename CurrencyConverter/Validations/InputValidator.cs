<<<<<<< HEAD
﻿namespace CurrencyConverter
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
=======
﻿using System;
using System.Collections.Generic;

namespace CurrencyConverter
{
    class InputValidator : IInputValidator
    {
        public void Validate(decimal amount)
        {
            try
            {

                if (amount <= 0)
                    throw new Exception("Invalid Amount");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
