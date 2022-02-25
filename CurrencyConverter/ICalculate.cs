using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public interface ICalculate
    {
        public decimal Calculate(string currency1, string currency2, decimal amount);
    }
}
