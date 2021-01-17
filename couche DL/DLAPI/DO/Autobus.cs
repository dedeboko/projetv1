using System;
using System.Collections.Generic;
using System.Text;

namespace couche_DL.DLAPI.DO
{
    public class Autobus
    {
        public int licenseNum { get; set; }
        public DateTime fromDate { get;  set; }
        public double totalTrip { get; set; }
        public double fuelremain { get; set; }
        public BusStatus Status { get; set; }
    }
}
