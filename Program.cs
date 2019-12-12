using System;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var station = new Wetterstation();
            var standard = new StandardAnzeige(station);
            var statistik = new StatistikAnzeige(station);
            
            while(true)
            {
                Console.SetCursorPosition(0, 0);
                station.neueDaten();
                Thread.Sleep(2000);
                
            }



        }
    }
}
