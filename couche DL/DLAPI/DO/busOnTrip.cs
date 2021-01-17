using System;
using System.Collections.Generic;
using System.Text;

namespace couche_DL.DLAPI.DO
{
    public class busOnTrip
    {
        public int id { get; set; }
        public int licenseNum { get; set; }
        public int lineld { get; set; }
        public DateTime PlannedTakeOff { get; set; }
        public DateTime ActualTakeOff { get; set; }
        public int PrevStation { get; set; }
        public DateTime PrevStationAt { get; set; }
        public DateTime NextStationAt { get; set; }


    }
}
