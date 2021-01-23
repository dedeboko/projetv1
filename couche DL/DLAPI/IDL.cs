using DO.DO;
using System;
using System.Collections.Generic;
using System.Text;

namespace couche_DL.DLAPI
{
    public interface IDL
    {
        #region autobus
        Boolean CreateAutobus(Autobus x);
        Boolean Deleteautobus(int ID);

        Autobus ReseachAAutobus(int id);

        List<Autobus> ReseachAllAutobus();

        Boolean UpdateAutobus(Autobus autobus);



        #endregion

        #region AdjacentStation
        Boolean CreateAdjacentStation(AdjacentStation adjacent);
        Boolean DeleteAdjacentStation(int id);
        AdjacentStation ReseachAAdjacentStation(int id);
        List<AdjacentStation>  ReseachAllAdjacentStation();

        Boolean UpdateAdajacent(AdjacentStation adjacent);

        #endregion

        #region busontrip
        bool CreatebusOnTrip(busOnTrip x);
        bool DeletebusOnTrip(int ID);
        busOnTrip  ResearchbusOnTrip(int ID);
        List<busOnTrip> ReseachbusOnTrip();
        bool UpdateAdajacent (busOnTrip busontrip);

        #endregion

        #region line
        bool CreateLine (Line x);
        bool DeleteLine(int ID);
        Line ReseachLine(int ID);
        List<Line> ReseachLine();
        bool UpdateAdajacent(Line ligne);
        #endregion

        #region LineStation
        bool CreateLineStation(Line x);
        bool DeleteLineStation(int ID);
        Line ReseachLineStation(int ID);
        List<Line> ReseachLineStation();
        bool UpdateLineStation(Line ligne);
        #endregion

        #region LineTrip
        bool CreateLineTrip(Line x);
        bool DeleteLineTrip(int ID);
        Line ReseachALineTrip(int ID);
        public List<BO.LineTrip> ReseachAllLineTrip();
        bool UpdateLineTrip( voyage);


        #endregion
    }
}
