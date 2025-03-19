using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Model
{
    public class Wijn
    {
        public int code { get; set; }
        public int jaar { get; set; }
        public string omschrijving { get; set; }
        public string inhoud { get; set; }
        public double ppf { get; set; }
        public int hoeveelheid { get; set; }
        public int voorraad { get; set; }
    }
}
