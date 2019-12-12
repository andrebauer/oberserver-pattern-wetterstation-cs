using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class VorhersageAnzeige : Beobachter
    {

        public VorhersageAnzeige(Subjekt subjekt)
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
            throw new NotImplementedException();
        }
    }
}
