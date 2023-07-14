using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    public class Wielopak
    {
        public Produkt Produkt { get; set; }
        public ushort Ilość { get; set; }
        private decimal cenaNetto;
        public decimal CenaNetto
        {
            get { return cenaNetto; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cena netto wielopaku nie może być ujemna.");
                cenaNetto = value;
            }
        }

        public decimal CenaBrutto
        {
            get { return CenaNetto * Ilość * (1 + StawkaVAT(Produkt.KategoriaVAT)); }
        }

        protected virtual decimal StawkaVAT(string kategoriaVAT)
        {
            return Produkt.StawkaVAT(kategoriaVAT);
        }

        public string KategoriaVAT
        {
            get { return Produkt.KategoriaVAT; }
        }

        public string KrajPochodzenia
        {
            get { return Produkt.KrajPochodzenia; }
            set { Produkt.KrajPochodzenia = value; }
        }
    }
}
