using couche_DL.DLAPI;
using DO.DO;
using System;
using System.Collections.Generic;
using System.Text;
using couche_DS;

namespace couche_DL.DLObject
{
    public class DLimp : IDL
    {

        #region autobus
        Boolean CreateAutobus(Autobus x)
        {

            Autobus a = Data.listAutobus.Find(y => x.licenseNum == y.licenseNum);
            if (a == null)
            {
                Data.listAutobus.Add(x.Clone());
                return true;
            }
            return false;




        }
        Boolean Deleteautobus(int ID)
        {
            Autobus a = Data.listAutobus.Find(y => y.licenseNum == ID);
            if (a == null)
            {
                return false;
            }
            else
            {
                Data.listAutobus.Remove(a);
                return true;
            }
        }

        Autobus ReseachAAutobus(int id)
        {

            Autobus a = Data.listAutobus.Find(y => y.licenseNum == id);
            if (a == null)
            {
                return null;
            }
            else
            {
                return a.Clone();
            }


        }

        List<Autobus> ReseachAllAutobus()
        {
            List<Autobus> rechima = new List<Autobus>();
            foreach (Autobus b in Data.listAutobus)
            {
                rechima.Add(b.Clone());
            }
            return rechima;
        }

        Boolean UpdateAutobus(Autobus autobus)
        {
            Autobus a = Data.listAutobus.Find(y => y.licenseNum == autobus.licenseNum);
            if (a == null)
            {
                return false;
            }
            else
            {
                Data.listAutobus.Remove (a);
                Data.listAutobus.Add(autobus);
                return true;
            }



        }

        #endregion
        #region BusOnTrip
        bool CreatebusOnTrip(busOnTrip x)
        {
            busOnTrip a = Data.listBusOnTrip.Find( y=> x.id == y.id);
            if (a == null)
            {
                Data.listBusOnTrip.Add(x.Clone());
                return true;
            }
            return false;
        }
        bool DeletebusOnTrip(int ID);
        busOnTrip ResearchbusOnTrip(int ID);
        List<busOnTrip> ReseachbusOnTrip();
        bool UpdateAdajacent(busOnTrip busontrip);
        #endregion
    }
}
