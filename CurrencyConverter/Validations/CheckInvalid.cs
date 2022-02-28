<<<<<<< HEAD
﻿namespace CurrencyConverter
{
    public class CheckInvalid : IUnknown
    {
        private IAllConversionsRepository _rates;

        public CheckInvalid(IAllConversionsRepository rates)
        {
            _rates = rates;
        }

=======
﻿using System;

namespace CurrencyConverter
{
    public class CheckInvalid : IUnknown
    { 
       private IAllConversionsRepository _rates;

       public CheckInvalid(IAllConversionsRepository rates)
        {
            _rates = rates;
        }
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
        public bool IsUnknown(string currency)
        {
            return !(_rates.GetConversionRates().ContainsKey(currency));
        }
    }
<<<<<<< HEAD
}
=======

}
>>>>>>> 6b1115edc8029231c6a83bb7f351516d1e119040
