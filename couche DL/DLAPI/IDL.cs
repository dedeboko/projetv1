using couche_DL.DLAPI.DO;
using System;
using System.Collections.Generic;
using System.Text;

namespace couche_DL.DLAPI
{
    public interface IDL
    {
        #region autobus
        Boolean CreateAutobus(DO.Autobus x);
        Boolean Deleteautobus(int ID);

        DO.Autobus ReseachAAutobus(int id);

        List<couche_DL.DLAPI.DO.Autobus> ReseachAllAutobus();

        Boolean UpdateAutobus(DO.Autobus autobus);



        #endregion

        #region AdjacentStation
        Boolean CreateAdjacentStation(DO.AdjacentStation adjacent);
        Boolean DeleteAdjacentStation(int id);
        DO.AdjacentStation ReseachAAdjacentStation(int id);
        List<DO.AdjacentStation>  ReseachAllAdjacentStation();

        Boolean UpdateAdajacent(DO.AdjacentStation adjacent);
        #endregion
    }
}
