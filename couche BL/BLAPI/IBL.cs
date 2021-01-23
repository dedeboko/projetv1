using System;
using System.Collections.Generic;
using System.Text;
using DO.DO;

//interface qui declare tt les fonctions de la couche BL
namespace couche_BL.BLAPI
{
    interface IBL
    {

        #region AdjacentStation

        DO.DO.AdjacentStation BOtoDOadapter(couche_BL.BO.AdjacentStation adjacent);
        couche_BL.BO.AdjacentStation DOtoBOadapter(DO.DO.AdjacentStation adjacent);
        Boolean CreateAdjacentStation(couche_BL.BO.AdjacentStation adjacent);
        List<couche_BL.BO.AdjacentStation> ReseachAllAdjacentStation();

        couche_BL.BO.AdjacentStation ReseachAAdjacentStation(int ID);
        Boolean UpdateAdajacent(couche_BL.BO.AdjacentStation adjacent);

        Boolean DeleteAdjacentStation(int ID);
        #endregion

        #region autobus
        public DO.DO.Autobus BOtoDOadapter(BO.Autobus adjacent);
        public BO.Autobus DOtoBOadapter(DO.DO.Autobus adjacent);
        public bool CreateAutobus(BO.Autobus adjacent);
        public bool Deleteautobus(int ID);
        public BO.Autobus ReseachAAautobus(int ID);
        public List<BO.Autobus> ReseachAllAutobus();
        public bool UpdateAutobus(BO.Autobus adjacent);

        #endregion

        #region busOntrip
        public DO.DO.busOnTrip BOtoDOadapter(BO.busOnTrip adjacent);
        public BO.busOnTrip DOtoBOadapter(DO.DO.busOnTrip adjacent);
        public bool CreatebusOnTrip(BO.busOnTrip adjacent);
        public bool DeletebusOnTrip(int ID);
        public BO.busOnTrip ResearchbusOnTrip(int ID);
        public List<BO.busOnTrip> ReseachbusOnTrip();
        public bool UpdatebusOnTrip(BO.AdjacentStation adjacent);
        #endregion

        #region line

        public DO.DO.Line BOtoDOadapter(BO.Line adjacent);
        public BO.Line DOtoBOadapter(DO.DO.Line adjacent);
        public bool Createline(BO.Line ligne);
        public bool DeleteLine(int ID);
        public BO.Line ReseachLine(int ID);
        public List<BO.Line> ReseachLine();
        public bool UpdateAdajacent(BO.Line ligne);
        #endregion

        #region LineStation
        public DO.DO.LineStation BOtoDOadapter(BO.LineStation line);
        public BO.LineStation DOtoBOadapter(DO.DO.LineStation line);
        public bool CreateAdjacentStation(BO.LineStation line);
        public bool DeleteLineStation(int ID);
        public BO.LineStation ReseachLineStation(int ID);
        public List<BO.LineStation> ReseachLineStation();
        public bool UpdateAdajacent(BO.LineStation line);


        #endregion

        #region LineTrip
        public DO.DO.LineTrip BOtoDOadapter(BO.LineTrip LineTrip);
        public BO.LineTrip DOtoBOadapter(DO.DO.LineTrip ligneTrip);
        public bool CreateAdjacentStation(BO.LineTrip adjacent);
        public bool DeleteLineTrip(int ID);
        public BO.LineTrip ReseachALineTrip(int ID);
        public List<BO.LineTrip> ReseachAllLineTrip();
        public bool UpdateAdajacent(BO.LineTrip adjacent);

        #endregion

        #region Trip
        public DO.DO.Trip BOtoDOadapter(BO.Trip adjacent);
        public BO.Trip DOtoBOadapter(DO.DO.Trip adjacent);
        public bool CreateTrip(BO.Trip trip);
        public bool DeleteTrip(int ID);
        public BO.Trip ReseachTrip(int ID);
        public List<BO.Trip> ReseachTrip();
        public bool UpdateTrip(BO.Trip trip);

        #endregion

        #region user
        public DO.DO.user BOtoDOadapter(BO.user utilisateur);
        public BO.user DOtoBOadapter(DO.DO.user utilisateur);
        public bool user(BO.user utilisateur);
        public bool Deleteuser(int ID);
        public List<BO.user> Reseachuser();
        public bool UpdateAdajacent(BO.user utlisateur);
        #endregion


    }
}
