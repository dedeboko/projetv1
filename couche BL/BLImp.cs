using couche_BL.BLAPI;
using System;
using System.Collections.Generic;
using System.Text;
//implemente les fonctions de la couche BL
namespace couche_BL
{
    class BLImp : IBL
    {
        couche_DL.DLAPI.IDL DL = couche_DL.DLAPI.DLFactory.returnDLObject();

        #region AdjacentStation

        public DO.DO.AdjacentStation BOtoDOadapter(BO.AdjacentStation adjacent)
        {
            DO.DO.AdjacentStation x = new DO.DO.AdjacentStation();
            x.ID = adjacent.ID;
            x.Station1 = adjacent.Sation1;
            x.Station2 = adjacent.Station2;
            x.Time = adjacent.Time;
            x.Distance = adjacent.Distance;
            return x;
        }

        public BO.AdjacentStation DOtoBOadapter(DO.DO.AdjacentStation adjacent)
        {
            BO.AdjacentStation x = new BO.AdjacentStation();
            x.ID = adjacent.ID;
            x.Sation1 = adjacent.Station1;
            x.Station2 = adjacent.Station2;
            x.Time = adjacent.Time;
            x.Distance = adjacent.Distance;
            return x;
        }

        public bool CreateAdjacentStation(BO.AdjacentStation adjacent)
        {
            DO.DO.AdjacentStation x = BOtoDOadapter(adjacent);
            return DL.CreateAdjacentStation(x);
        }



        public bool DeleteAdjacentStation(int ID)
        {
           return DL.DeleteAdjacentStation(ID);
        }

        

        public BO.AdjacentStation ReseachAAdjacentStation(int ID)
        {
            DO.DO.AdjacentStation x = DL.ReseachAAdjacentStation(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.AdjacentStation> ReseachAllAdjacentStation()
        {
            List<DO.DO.AdjacentStation> x = DL.ReseachAllAdjacentStation();
            List<BO.AdjacentStation> returnList = new List<BO.AdjacentStation>();
            foreach(var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateAdajacent(BO.AdjacentStation adjacent)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(adjacent));
        }
        #endregion

        #region Autobus
       
        public couche_DL.DLAPI.DO.Autobus BOtoDOadapter(BO.Autobus bus)
        {
            couche_DL.DLAPI.DO.Autobus x = new couche_DL.DLAPI.DO.Autobus();
            x.fromDate = bus.fromDate;
            x.fuelremain = bus.fuelremain;
            x.licenseNum = bus.licenseNum;
            x.Status = (couche_DL.DLAPI.DO.BusStatus)((int)bus.Status);
            x.totalTrip = bus.totalTrip;
            return x;
        }

        public BO.Autobus DOtoBOadapter(couche_DL.DLAPI.DO.Autobus bus)
        {
            BO.Autobus x = new BO.Autobus();
            x.fromDate = bus.fromDate;
            x.fuelremain = bus.fuelremain;
            x.licenseNum = bus.licenseNum;
            x.Status = (BO.BusStatus)((int)bus.Status);
            x.totalTrip = bus.totalTrip;
            return x;
        }

        public bool CreateAutobus(BO.Autobus bus)
        {
            couche_DL.DLAPI.DO.Autobus x = BOtoDOadapter(bus);
            return DL.CreateAutobus(x);
        }



        public bool Deleteautobus(int ID)
        {
            return DL.Deleteautobus(ID);
        }



        public BO.Autobus ReseachAAautobus(int ID)
        {
            couche_DL.DLAPI.DO.Autobus x = DL.ReseachAAutobus(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.Autobus> ReseachAllAutobus()
        {
            List<couche_DL.DLAPI.DO.Autobus> x = DL.ReseachAllAutobus();
            List<BO.Autobus> returnList = new List<BO.Autobus>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateAutobus(BO.Autobus adjacent)
        {
            return DL.UpdateAutobus(BOtoDOadapter(adjacent));
        }
        #endregion

        #region busOnTrip
        public DO.DO.busOnTrip BOtoDOadapter(BO.busOnTrip adjacent)
        {
            couche_DL.DLAPI.DO.busOnTrip x = new couche_DL.DLAPI.DO.busOnTrip();
            x.id = adjacent.id;
            x.licenseNum = adjacent.licenseNum;
            x.lineld = adjacent.lineld;
            x.NextStationAt = adjacent.NextStationAt;
            x.PlannedTakeOff = adjacent.PlannedTakeOff;
            x.PrevStation = adjacent.PrevStation;
            x.PrevStationAt = adjacent.PrevStationAt;
            return x;
        }

        public BO.busOnTrip DOtoBOadapter(DO.DO.busOnTrip adjacent)
        {
            BO.busOnTrip x = new BO.busOnTrip();
            x.id = adjacent.id;
            x.licenseNum = adjacent.licenseNum;
            x.lineld = adjacent.lineld;
            x.NextStationAt = adjacent.NextStationAt;
            x.PlannedTakeOff = adjacent.PlannedTakeOff;
            x.PrevStation = adjacent.PrevStation;
            x.PrevStationAt = adjacent.PrevStationAt;
            return x;
        }

        public bool CreatebusOnTrip(BO.busOnTrip adjacent)//petite betise dlfactory
        {
            couche_DL.DLAPI.DO.busOnTrip x = BOtoDOadapter(adjacent);
            return DL.CreatebusOnTrip(x);
        }



        public bool DeletebusOnTrip(int ID)
        {
            return DL.DeletebusOnTrip(ID);
        }



        public BO.busOnTrip ResearchbusOnTrip(int ID)
        {
            DO.DO.busOnTrip x = DL.ResearchbusOnTrip(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.busOnTrip> ReseachbusOnTrip()
        {
            List<DO.DO.busOnTrip> x = DL.ReseachbusOnTrip();
            List<BO.busOnTrip> returnList = new List<BO.busOnTrip>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdatebusOnTrip(BO.AdjacentStation adjacent)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(adjacent));
        }
        #endregion        

        #region Line

        public DO.DO.Line BOtoDOadapter(BO.Line adjacent)//g rajoute une variable dans le line.cs
        {
            DO.DO.Line x = new DO.DO.Line();
           
            return x;
        }

        public BO.Line DOtoBOadapter(DO.DO.Line adjacent)
        {
            BO.Line x = new BO.Line();
            
            return x;
        }

        public bool Createline(BO.Line ligne)
        {
            DO.DO.Line x = BOtoDOadapter(ligne);
            return DL.CreateLine(x);
        }



        public bool DeleteLine(int ID)
        {
            return DL.DeleteLine(ID);
        }



        public BO.Line ReseachLine(int ID)
        {
            DO.DO.Line x = DL.ReseachLine(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.Line> ReseachLine()
        {
            List<DO.DO.Line> x = DL.ReseachLine();
            List<BO.Line> returnList = new List<BO.Line>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateAdajacent(BO.Line ligne)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(ligne));
        }
        #endregion

        #region LineStation

        public DO.DO.LineStation BOtoDOadapter(BO.LineStation line)
        {
            DO.DO.LineStation x = new DO.DO.LineStation();
            x.lineLd = line.lineLd;
            x.LineStationIndex = line.LineStationIndex;
            x.nextStation = line.nextStation;
            x.prevStation= line.prevStation;
            x.Station = line.Station;
            return x;
        }

        public BO.LineStation DOtoBOadapter(DO.DO.LineStation line)
        {
            BO.LineStation x = new BO.LineStation();
            x.lineLd = line.lineLd;
            x.LineStationIndex = line.LineStationIndex;
            x.nextStation = line.nextStation;
            x.prevStation = line.prevStation;
            x.Station = line.Station;
            return x;
        }

        public bool CreateLineStation(BO.LineStation line)
        {
            DO.DO.LineStation x = BOtoDOadapter(line);
            return DL.CreateAdjacentStation(x);//je comprends pas
        }



        public bool DeleteLineStation(int ID)
        {
            return DL.DeleteAdjacentStation(ID);
        }



        public BO.LineStation ReseachLineStation(int ID)
        {
           DO.DO.LineStation x = DL.ReseachLineStation(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.LineStation> ReseachLineStation()
        {
            List<DO.DO.LineStation> x = DL.ReseachLineStation();
            List<BO.LineStation> returnList = new List<BO.LineStation>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateLineStation(BO.LineStation line)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(line));
        }
        #endregion

        #region LineTrip

        public DO.DO.LineTrip BOtoDOadapter(BO.LineTrip LineTrip)
        {
            couche_DL.DLAPI.DO.LineTrip x = new couche_DL.DLAPI.DO.LineTrip();
            x.FinishAt = LineTrip.FinishAt;
            x.Frequency= LineTrip.Frequency;
            x.id = LineTrip.id;
            x.Lineld = LineTrip.Lineld;
            x.StartAt= LineTrip.StartAt;
            return x;
        }

        public BO.LineTrip DOtoBOadapter(DO.DO.LineTrip ligneTrip)
        {
            BO.LineTrip x = new BO.LineTrip();
            x.FinishAt = ligneTrip.FinishAt;
            x.Frequency = ligneTrip.Frequency;
            x.id = ligneTrip.id;
            x.Lineld = ligneTrip.Lineld;
            x.StartAt = ligneTrip.StartAt;
            return x;
        }

        public bool CreateLineTrip(BO.LineTrip adjacent)
        {
            DO.DO.LineTrip x = BOtoDOadapter(adjacent);
            return DL.CreateAdjacentStation(x);
        }



        public bool DeleteLineTrip(int ID)
        {
            return DL.DeleteAdjacentStation(ID);
        }



        public BO.LineTrip ReseachALineTrip(int ID)
        {
            DO.DO.LineTrip x = DL.ReseachALineTrip(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.LineTrip> ReseachAllLineTrip()
        {
            List<DO.DO.LineTrip> x = DL.ReseachAllLineTrip();
            List<BO.LineTrip> returnList = new List<BO.LineTrip>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdatelineTrip(BO.LineTrip voyage)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(voyage));
        }
        #endregion

        

       




    }
}
