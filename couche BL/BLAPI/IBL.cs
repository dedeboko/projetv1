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

        #endregion
        #region AdjacentStation

        #endregion
    }
}
