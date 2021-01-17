using System;
using System.Collections.Generic;
using System.Text;

namespace couche_BL.BO
{
    public class LineStation
    {
        public int lineLd { get; set; }
        public int Station { get; set; }
        public int LineStationIndex { get; set; }
        public int prevStation { get; set; }
        public int nextStation { get; set; }

    }
}
