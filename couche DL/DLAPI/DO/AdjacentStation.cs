using System;
using System.Collections.Generic;
using System.Text;

namespace couche_DL.DLAPI.DO
{
    public class AdjacentStation
    {
        public int ID { get; set; }
        public int Sation1 { get; set; }
        public int Station2 { get; set; }
        public double Distance { get; set; }
        public DateTime Time { get; set; }
    }
}
