using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_CS
{
    enum Bloodtype { Cold, Warm, None };
    enum ConservationStatus { EX, EW, CR, EN, VU, NT, LC, Unknown };

    class Animalia
    {
        public Bloodtype bloodtype { get; set; }
        public ConservationStatus conservation { get; set; } = ConservationStatus.Unknown;
        public string BinomalName{get; set;} 
        public string CommonName { get; set; }

    }
}
