using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Seance2DMWMCSharp
{
    public static class ExtensionProduct
    {
        public static int TotalPrices(this ProductsList products)
        {
            int total = 0;
            foreach(Produit prod in products.Produits)
            {
                total += prod.Prix;
            }
            return total;
        }
    }
}
