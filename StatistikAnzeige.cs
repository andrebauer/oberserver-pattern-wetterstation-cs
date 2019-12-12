using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public class StatistikAnzeige : Beobachter
    {
        public StatistikAnzeige(Subjekt subjekt)
        {
            if (subjekt is Wetterstation)
            {
                wetterstation = (Wetterstation)subjekt;
                wetterstation.verbinden(this);
            }
            luftdruckCollection = new List<double>();
            temperaturCollection = new List<double>();
            luftfeuchteCollection = new List<double>();

        }

        public List<double> luftdruckCollection { get; private set; }
        public List<double> temperaturCollection { get; private set; }
        public List<double> luftfeuchteCollection { get; private set; }
        Wetterstation wetterstation { get; }

        public void aktualisiere()
        {
            SetCurrentValues();
            Console.Write("\r{0}\n", $"----- MIN/MAX der letzten 10 Messungen -----");
            Console.Write("\r{0}\n", $"Luftdruck: {luftdruckCollection.Min().Format(2)} / {luftdruckCollection.Max().Format(2)} hpa");
            Console.Write("\r{0}\n", $"Luftfeuchte: {luftfeuchteCollection.Min().Format(2)} / {luftfeuchteCollection.Max().Format(2)} %");
            Console.Write("\r{0}\n", $"Temperatur: {temperaturCollection.Min().Format(2)} / {temperaturCollection.Max().Format(2)} °C");
            Console.Write("\r{0}\n", $"--------------------------------------------");
            Console.Write("\r{0}\n", $" ");
        }

        private void SetCurrentValues()
        {
            luftdruckCollection.Add(wetterstation.luftdruck);
            temperaturCollection.Add(wetterstation.temperatur);
            luftfeuchteCollection.Add(wetterstation.luftfeuchte);
            if (luftdruckCollection.Count > 10)
            {
                luftdruckCollection.RemoveAt(0);
                temperaturCollection.RemoveAt(0);
                luftfeuchteCollection.RemoveAt(0);
            }
        }
    }
}
