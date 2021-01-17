using System;
using System.Collections.Generic;
using System.Text;

namespace couche_BL.BO
{
    public class Trip
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public int Lineld { get; set; }
        public int InStation { get; set; }
        public DateTime TimeSpan { get; set; }
        public int OutStation { get; set; }
        public DateTime OutAt { get; set; }
    }

}
