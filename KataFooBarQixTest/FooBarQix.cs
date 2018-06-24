using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace KataFooBarQixTest
{
    internal class FooBarQix
    {
        internal string compute(string v)
        {
            var result = String.Empty; ;
            var val = int.Parse(v);

            if (!NonDivisibleByAny(val))
            {
                result = val.ToString().Replace('0', '*');
            }
            else
            {
                if (Divisble(val, 3))
                {
                    result += "Foo";
                }
                if (Divisble(val, 5))
                {
                    result += "Bar";
                }
                if (Divisble(val, 7))
                {
                    result += "Qix";
                }
            }

            return result;
        }

        public bool Divisble(int val, int v)
        {
            return (val % v) == 0;
        }

        private bool NonDivisibleByAny(int num)
        {
            return (!(num % 3 == 0) && !(num % 5 == 0) && !(num % 7 == 0)) ? false : true;
        }

    }
}