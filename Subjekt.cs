using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Subjekt
    {
        public List<Beobachter> beobachter;

        public Subjekt()
        {
            beobachter = new List<Beobachter>();
        }

        public void verbinden(Beobachter b)
            => beobachter.Add(b);
        

        public void trennen(Beobachter b)
            => beobachter.Remove(b);


        protected void benachrichtigeBeobachter()
            => beobachter.ForEach(_ => _.aktualisiere());

    }
}
