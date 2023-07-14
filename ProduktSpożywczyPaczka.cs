using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    public class ProduktSpożywczyPaczka : ProduktSpożywczy
    {
        public ProduktSpożywczyPaczka()
        {
            Alergeny = new HashSet<string>();
        }
    }
}
