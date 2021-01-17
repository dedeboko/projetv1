using System;
using System.Collections.Generic;
using System.Text;
//classe statique qui declare une fonction qui ramene l objet BL important
namespace couche_BL.BLAPI
{
    static class BLFactory
    {
        static BLImp createBL() 
        {
            return new BLImp();
        }

    }
}
