using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class StandardAnzeige : Beobachter
    {
        public StandardAnzeige(Subjekt subjekt)
        {
            if (subjekt is Wetterstation)
            {
                wetterstation = (Wetterstation)subjekt;
                wetterstation.verbinden(this);
            }
        }
        Wetterstation wetterstation { get; }

        public void aktualisiere()
        {
            Console.Write("\r{0}\n", $"----- Aktuelle Daten -----");
            Console.Write("\r{0}\n", $"Luftdruck: {wetterstation.luftdruck.Format(2)} hpa");
            Console.Write("\r{0}\n", $"Luftfeuchte: {wetterstation.luftfeuchte.Format(2)} %");
            Console.Write("\r{0}\n", $"Temperatur: {wetterstation.temperatur.Format(2)} °C");
            Console.Write("\r{0}\n", $"--------------------------");
            Console.Write("\r{0}\n", $" ");
        }
    }
}
