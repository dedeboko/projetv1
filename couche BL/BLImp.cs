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
            x.Sation1 = adjacent.Sation1;
            x.Station2 = adjacent.Station2;
            x.Time = adjacent.Time;
            x.Distance = adjacent.Distance;

            return x;
        }

        public BO.AdjacentStation DOtoBOadapter(couche_DL.DLAPI.DO.AdjacentStation adjacent)
        {
            BO.AdjacentStation x = new BO.AdjacentStation();
            x.ID = adjacent.ID;
            x.Sation1 = adjacent.Sation1;
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
       
        public couche_DL.DLAPI.DO.Autobus BOtoDOadapter(BO.Autobus adjacent)
        {
            couche_DL.DLAPI.DO.Autobus x = new couche_DL.DLAPI.DO.Autobus();
            x.fromDate = adjacent.fromDate;
            x.fuelremain = adjacent.fuelremain;
            x.licenseNum = adjacent.licenseNum;
            x.Status = (couche_DL.DLAPI.DO.BusStatus)((int) adjacent.Status);
            x.totalTrip = adjacent.totalTrip;
            return x;
        }

        public BO.Autobus DOtoBOadapter(couche_DL.DLAPI.DO.Autobus adjacent)
        {
            BO.Autobus x = new BO.Autobus();
            x.fromDate = adjacent.fromDate;
            x.fuelremain = adjacent.fuelremain;
            x.licenseNum = adjacent.licenseNum;
            x.Status = (BO.BusStatus)((int)adjacent.Status);
            x.totalTrip = adjacent.totalTrip;
            return x;
        }

        public bool CreateAutobus(BO.Autobus adjacent)
        {
            couche_DL.DLAPI.DO.Autobus x = BOtoDOadapter(adjacent);
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
    }
}
