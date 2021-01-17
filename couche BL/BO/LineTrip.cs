using System;
using System.Collections.Generic;
using System.Text;

namespace couche_BL.BO
{
    public class LineTrip
    {

        public int id { get; set; }
        public int Lineld { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime Frequency { get; set; }
        public DateTime FinishAt { get; set; }
    }
}
