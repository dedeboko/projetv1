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

        public couche_DL.DLAPI.DO.AdjacentStation BOtoDOadapter(BO.AdjacentStation adjacent)
        {
            couche_DL.DLAPI.DO.AdjacentStation x = new couche_DL.DLAPI.DO.AdjacentStation();
            x.ID = adjacent.ID;
            x.Station1 = adjacent.Sation1;
            x.Station2 = adjacent.Station2;
            x.Time = adjacent.Time;
            x.Distance = adjacent.Distance;
            return x;
        }

        public BO.AdjacentStation DOtoBOadapter(couche_DL.DLAPI.DO.AdjacentStation adjacent)
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
            couche_DL.DLAPI.DO.AdjacentStation x = BOtoDOadapter(adjacent);
            return DL.CreateAdjacentStation(x);
        }



        public bool DeleteAdjacentStation(int ID)
        {
           return DL.DeleteAdjacentStation(ID);
        }

        

        public BO.AdjacentStation ReseachAAdjacentStation(int ID)
        {
            couche_DL.DLAPI.DO.AdjacentStation x = DL.ReseachAAdjacentStation(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.AdjacentStation> ReseachAllAdjacentStation()
        {
            List<couche_DL.DLAPI.DO.AdjacentStation> x = DL.ReseachAllAdjacentStation();
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
        public couche_DL.DLAPI.DO.busOnTrip BOtoDOadapter(BO.busOnTrip adjacent)
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

        public BO.busOnTrip DOtoBOadapter(couche_DL.DLAPI.DO.busOnTrip adjacent)
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
            couche_DL.DLAPI.DO.busOnTrip x = DL.ResearchbusOnTrip(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.busOnTrip> ReseachbusOnTrip()
        {
            List<couche_DL.DLAPI.DO.busOnTrip> x = DL.ReseachbusOnTrip();
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

        #region BusStatus
        public couche_DL.DLAPI.DO.BusStatus BOtoDOadapter(BO.BusStatus adjacent)
        {
            couche_DL.DLAPI.DO.BusStatus x = new couche_DL.DLAPI.DO.BusStatus();
            
            return x;
        }

        public BO.BusStatus DOtoBOadapter(couche_DL.DLAPI.DO.BusStatus adjacent)
        {
            BO.BusStatus x = new BO.BusStatus();
            
            return x;
        }

        public bool CreateAdjacentStation(BO.BusStatus status)
        {
            couche_DL.DLAPI.DO.BusStatus x = BOtoDOadapter(status);
            return DL.CreateBusStatus(x);
        }



        public bool DeleteBusStatus(int ID)
        {
            return DL.DeleteBusStatus(ID);
        }



        public BO.BusStatus ReseachBusStatus(int ID)
        {
            couche_DL.DLAPI.DO.BusStatus x = DL.ReseachBusStatus(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.BusStatus> ReseachBusStatus()
        {
            List<couche_DL.DLAPI.DO.BusStatus> x = DL.ReseachBusStatus();
            List<BO.BusStatus> returnList = new List<BO.BusStatus>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateAdajacent(BO.BusStatus status)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(status));
        }

        #endregion

        #region Line

        public couche_DL.DLAPI.DO.Line BOtoDOadapter(BO.Line adjacent)//g rajoute une variable dans le line.cs
        {
            couche_DL.DLAPI.DO.Line x = new couche_DL.DLAPI.DO.Line();
           
            return x;
        }

        public BO.Line DOtoBOadapter(couche_DL.DLAPI.DO.Line adjacent)
        {
            BO.Line x = new BO.Line();
            
            return x;
        }

        public bool CreateAdjacentStation(BO.Line ligne)
        {
            couche_DL.DLAPI.DO.Line x = BOtoDOadapter(ligne);
            return DL.CreateLine(x);
        }



        public bool DeleteLine(int ID)
        {
            return DL.DeleteAdjacentStation(ID);
        }



        public BO.Line ReseachLine(int ID)
        {
            couche_DL.DLAPI.DO.Line x = DL.ReseachLine(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.Line> ReseachLine()
        {
            List<couche_DL.DLAPI.DO.Line> x = DL.ReseachLine();
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

        public couche_DL.DLAPI.DO.LineStation BOtoDOadapter(BO.LineStation line)
        {
            couche_DL.DLAPI.DO.LineStation x = new couche_DL.DLAPI.DO.LineStation();
            x.lineLd = line.lineLd;
            x.LineStationIndex = line.LineStationIndex;
            x.nextStation = line.nextStation;
            x.prevStation= line.prevStation;
            x.Station = line.Station;
            return x;
        }

        public BO.LineStation DOtoBOadapter(couche_DL.DLAPI.DO.LineStation line)
        {
            BO.LineStation x = new BO.LineStation();
            x.lineLd = line.lineLd;
            x.LineStationIndex = line.LineStationIndex;
            x.nextStation = line.nextStation;
            x.prevStation = line.prevStation;
            x.Station = line.Station;
            return x;
        }

        public bool CreateAdjacentStation(BO.LineStation line)
        {
            couche_DL.DLAPI.DO.LineStation x = BOtoDOadapter(line);
            return DL.CreateAdjacentStation(x);
        }



        public bool DeleteLineStation(int ID)
        {
            return DL.DeleteAdjacentStation(ID);
        }



        public BO.LineStation ReseachLineStation(int ID)
        {
            couche_DL.DLAPI.DO.LineStation x = DL.ReseachLineStation(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.LineStation> ReseachLineStation()
        {
            List<couche_DL.DLAPI.DO.LineStation> x = DL.ReseachLineStation();
            List<BO.LineStation> returnList = new List<BO.LineStation>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateAdajacent(BO.LineStation line)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(line));
        }
        #endregion

        #region LineTrip

        public couche_DL.DLAPI.DO.LineTrip BOtoDOadapter(BO.LineTrip LineTrip)
        {
            couche_DL.DLAPI.DO.LineTrip x = new couche_DL.DLAPI.DO.LineTrip();
            x.FinishAt = LineTrip.FinishAt;
            x.Frequency= LineTrip.Frequency;
            x.id = LineTrip.id;
            x.Lineld = LineTrip.Lineld;
            x.StartAt= LineTrip.StartAt;
            return x;
        }

        public BO.LineTrip DOtoBOadapter(couche_DL.DLAPI.DO.LineTrip ligneTrip)
        {
            BO.LineTrip x = new BO.LineTrip();
            x.FinishAt = ligneTrip.FinishAt;
            x.Frequency = ligneTrip.Frequency;
            x.id = ligneTrip.id;
            x.Lineld = ligneTrip.Lineld;
            x.StartAt = ligneTrip.StartAt;
            return x;
        }

        public bool CreateAdjacentStation(BO.LineTrip adjacent)
        {
            couche_DL.DLAPI.DO.LineTrip x = BOtoDOadapter(adjacent);
            return DL.CreateAdjacentStation(x);
        }



        public bool DeleteAdjacentStation(int ID)
        {
            return DL.DeleteAdjacentStation(ID);
        }



        public BO.LineTrip ReseachAAdjacentStation(int ID)
        {
            couche_DL.DLAPI.DO.LineTrip x = DL.ReseachAAdjacentStation(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.LineTrip> ReseachAllAdjacentStation()
        {
            List<couche_DL.DLAPI.DO.LineTrip> x = DL.ReseachAllAdjacentStation();
            List<BO.LineTrip> returnList = new List<BO.LineTrip>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateAdajacent(BO.LineTrip adjacent)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(adjacent));
        }
        #endregion

        #region Trip

        public couche_DL.DLAPI.DO.Trip BOtoDOadapter(BO.Trip adjacent)
        {
            couche_DL.DLAPI.DO.Trip x = new couche_DL.DLAPI.DO.Trip();
           
            return x;
        }

        public BO.Trip DOtoBOadapter(couche_DL.DLAPI.DO.Trip adjacent)
        {
            BO.Trip x = new BO.Trip();
           
            return x;
        }

        public bool CreateTrip(BO.Trip trip)
        {
            couche_DL.DLAPI.DO.Trip x = BOtoDOadapter(trip);
            return DL.CreateTrip(x);
        }



        public bool DeleteTrip(int ID)
        {
            return DL.DeleteAdjacentStation(ID);
        }



        public BO.Trip ReseachTrip(int ID)
        {
            couche_DL.DLAPI.DO.Trip x = DL.ReseachTrip(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.Trip> ReseachTrip()
        {
            List<couche_DL.DLAPI.DO.Trip> x = DL.ReseachTrip();
            List<BO.Trip> returnList = new List<BO.Trip>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateTrip(BO.Trip trip)
        {
            return DL.UpdateTrip(BOtoDOadapter(trip));
        }
        #endregion

        #region user

        public couche_DL.DLAPI.DO.user BOtoDOadapter(BO.user utilisateur)
        {
            couche_DL.DLAPI.DO.user x = new couche_DL.DLAPI.DO.user();
            return x;
        }

        public BO.user DOtoBOadapter(couche_DL.DLAPI.DO.user utilisateur)
        {
            BO.user x = new BO.user();
            
            return x;
        }

        public bool user(BO.user utilisateur)
        {
            couche_DL.DLAPI.DO.user x = BOtoDOadapter(utilisateur);
            return DL.CreateAdjacentStation(x);
        }



        public bool Deleteuser(int ID)
        {
            return DL.DeleteAdjacentStation(ID);
        }



        public bool user(BO.user utilisateur)
        public BO.user Reseachuser(int ID)
        {
            couche_DL.DLAPI.DO.user x = DL.Reseachuser(ID);
            return DOtoBOadapter(x);
        }

        public List<BO.user> Reseachuser()
        {
            List<couche_DL.DLAPI.DO.user> x = DL.Reseachuser();
            List<BO.user> returnList = new List<BO.user>();
            foreach (var DO in x)
            {
                returnList.Add(DOtoBOadapter(DO));
            }
            return returnList;
        }

        public bool UpdateAdajacent(BO.user utlisateur)
        {
            return DL.UpdateAdajacent(BOtoDOadapter(utlisateur));
        }
        #endregion




    }
}
