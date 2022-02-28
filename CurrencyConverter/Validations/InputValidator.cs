using System;
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
