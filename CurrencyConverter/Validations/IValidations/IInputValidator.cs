using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public interface IInputValidator
    {
        public void Validate(decimal amount);
    }
}
