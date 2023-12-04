using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklepUvovy
{
    internal class Adres
    {
        public string ulica;
        public string kodPocztowy;
        public string miejscowosc;
        public string numerPosesji;
        public string numerLokalu;

        public Adres(string ulica, string kodPocztowy, string miejscowosc, string numerPosesji, string numerLokalu)
        {
            this.ulica = ulica;
            this.kodPocztowy = kodPocztowy;
            this.miejscowosc = miejscowosc;
            this.numerPosesji = numerPosesji;
            this.numerLokalu = numerLokalu;
        }
    }
}
