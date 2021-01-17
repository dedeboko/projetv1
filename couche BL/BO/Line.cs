using System;
using System.Collections.Generic;
using System.Text;

namespace couche_BL.BO
{
    public class Line
    {
        public int id { get; set; }
        public int code { get; set; }
        public int areas { get; set; }
        public int FirstStation { get; set; }
        public int LastStation { get; set; }
    }
}
