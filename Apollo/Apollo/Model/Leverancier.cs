using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Model
{
    public class Leverancier
    {
        public int id { get; set; }
        public string firmanaam { get; set; }
        public string adres { get; set; }
        public string postnr { get; set; }
        public string gemeente { get; set; }
    }
}
