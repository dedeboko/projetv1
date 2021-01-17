using couche_DL.DLAPI.DO;
using System;
using System.Collections.Generic;
using System.Text;

namespace couche_DL.DLAPI
{
    interface IDL
    {
        #region autobus
        public void addAutobus(Autobus autobus);
        public void removeAutobus(int id);
        public void updateAutobus(Autobus autobus);
        public Autobus getAutobus(int id);
        public List<Autobus> getAllAutobus();



        #endregion
    }
}
