using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    public class ProduktSpożywczy : Produkt
    {
        public decimal Kalorie { get; set; }
        public HashSet<string> Alergeny { get; set; }
    }
}
