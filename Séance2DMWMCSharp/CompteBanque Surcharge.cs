using System;
using System.Collections.Generic;
using System.Text;

namespace Séance2DMWMCSharp
{
    class CompteBanque_Surcharge
    {
        int solde;
        public CompteBanque_Surcharge(int solde)
        {
            this.solde = solde;
        }
        public static bool operator
            ==(CompteBanque_Surcharge c1, CompteBanque_Surcharge c2)
        {
            if (c1.solde == c2.solde)
            {
                return true;

            }
            else
            { return false; }
        }
        public static bool operator
            !=(CompteBanque_Surcharge c1, CompteBanque_Surcharge c2)
        {
            return !(c1 == c2);  
        }
        public static CompteBanque_Surcharge operator
            +(CompteBanque_Surcharge c1, CompteBanque_Surcharge c2)
        {
            return new CompteBanque_Surcharge(c1.solde + c2.solde);
        }


    }
}
