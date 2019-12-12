using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Wetterstation : Subjekt
    {
        public double temperatur { get => (20.0 + Rand.R.NextDouble() * 5); }

        public double luftfeuchte { get => (20.0 + Rand.R.NextDouble() * 40); }

        public double luftdruck { get => (1100.0 + Rand.R.NextDouble() * 50); }

        public void neueDaten() => benachrichtigeBeobachter();
    }
}
