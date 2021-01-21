using System;
using System.Collections.Generic;
using System.Text;

//interface qui declare tt les fonctions de la couche BL
namespace couche_BL.BLAPI
{
    interface IBL
    {

        #region AdjacentStation

        couche_DL.DLAPI.DO.AdjacentStation BOtoDOadapter(couche_BL.BO.AdjacentStation adjacent);
        couche_BL.BO.AdjacentStation DOtoBOadapter(couche_DL.DLAPI.DO.AdjacentStation adjacent);
        Boolean CreateAdjacentStation(couche_BL.BO.AdjacentStation adjacent);
        List<couche_BL.BO.AdjacentStation> ReseachAllAdjacentStation();

        couche_BL.BO.AdjacentStation ReseachAAdjacentStation(int ID);
        Boolean UpdateAdajacent(couche_BL.BO.AdjacentStation adjacent);

        Boolean DeleteAdjacentStation(int ID);
        #endregion

        #region autobus
        public couche_DL.DLAPI.DO.Autobus BOtoDOadapter(BO.Autobus adjacent);
        public BO.Autobus DOtoBOadapter(couche_DL.DLAPI.DO.Autobus adjacent);
        public bool CreateAutobus(BO.Autobus adjacent);
        public bool Deleteautobus(int ID);
        public BO.Autobus ReseachAAautobus(int ID);
        public List<BO.Autobus> ReseachAllAutobus();
        public bool UpdateAutobus(BO.Autobus adjacent);

        #endregion

        #region busOntrip
        public couche_DL.DLAPI.DO.busOnTrip BOtoDOadapter(BO.busOnTrip adjacent);
        public BO.busOnTrip DOtoBOadapter(couche_DL.DLAPI.DO.busOnTrip adjacent);
        public bool CreatebusOnTrip(BO.busOnTrip adjacent);
        public bool DeletebusOnTrip(int ID);
        public BO.busOnTrip ResearchbusOnTrip(int ID);
        public List<BO.busOnTrip> ReseachbusOnTrip();
        public bool UpdatebusOnTrip(BO.AdjacentStation adjacent);
        #endregion


        #region BusStatus
        public couche_DL.DLAPI.DO.BusStatus BOtoDOadapter(BO.BusStatus adjacent);
        public BO.BusStatus DOtoBOadapter(couche_DL.DLAPI.DO.BusStatus adjacent);
        public bool CreateAdjacentStation(BO.BusStatus status);
        public bool DeleteBusStatus(int ID);
        public BO.BusStatus ReseachBusStatus(int ID);
        public List<BO.BusStatus> ReseachBusStatus();
        public bool UpdateAdajacent(BO.BusStatus status);

        #endregion
        #region Line

        public couche_DL.DLAPI.DO.Line BOtoDOadapter(BO.Line adjacent);
        public BO.Line DOtoBOadapter(couche_DL.DLAPI.DO.Line adjacent);
        public bool CreateAdjacentStation(BO.Line ligne);
        public bool DeleteLine(int ID);
        public BO.Line ReseachLine(int ID);
        public List<BO.Line> ReseachLine();
        public bool UpdateAdajacent(BO.Line ligne);
        #endregion

        #region LineStation
        public couche_DL.DLAPI.DO.LineStation BOtoDOadapter(BO.LineStation line);
        public BO.LineStation DOtoBOadapter(couche_DL.DLAPI.DO.LineStation line);


        #endregion

        #region LineTrip
        #endregion
    }
}
