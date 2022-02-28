using System;
using System.Collections.Generic;


namespace CurrenctConverterTestDemo1
{
    public class Expected
    {
        public static IEnumerable<object[]> ExpectedValue1()
        {
            yield return new object[] { "EUR", "DKK", 1, 12m };
            yield return new object[] { "EUR", "USD", 2, 22m };
        }
        public static IEnumerable<object[]> ExpectedValue2()
        {
            yield return new object[] { "EUR", "DKK", 1, 7.4394m };
        }
    }


        //can get value from external api by passing parameters

    }

