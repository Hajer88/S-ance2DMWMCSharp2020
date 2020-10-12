using System;
using System.Collections.Generic;
using System.Text;

namespace Séance2DMWMCSharp
{
    class CompteEnBanque
    {
        float solde;
        public CompteEnBanque()
        {
            solde = 0;
        }
        public void credit(float montant)
        {
            solde += montant;
        }
        public void debit(float montant)
        {
            if(solde-montant > 0)
            {
                solde -= montant;
            }
        }
        public int LireSolde()
        {
            return (int)solde;
        }
    }
}
