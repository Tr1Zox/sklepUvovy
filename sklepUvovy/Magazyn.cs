using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklepUvovy
{ 
    internal class Magazyn
    {
        public List<Produkt> produkty;
        public Adres adresMagazynu;

        public Magazyn(List<Produkt> produkty, Adres adresMagazynu)
        {
            this.produkty = new List<Produkt>();
            this.adresMagazynu = adresMagazynu;
        }
    }
}
