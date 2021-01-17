using System;
using System.Collections.Generic;
using System.Text;

namespace couche_DL.DLAPI
{
    public class DLFactory
    {
        public static IDL returnDLObject()
        {
            return new couche_DL.DLObject.DLimp();
        }
    }
}
