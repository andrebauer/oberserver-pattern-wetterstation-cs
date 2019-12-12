using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public static class DoubleExtensions
    {
        public static double SetComma(this double d, int digits)
            => Math.Round(d, digits, MidpointRounding.ToEven);

        public static string Format(this double d, int digits)
            => d.ToString($"F{digits}");

    }
}
