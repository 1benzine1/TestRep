using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Data
{
    public class YardRacers
    {
        public int Id { get; set; }
        public string NameRacer { get; set; }

        public DateTime Birthday { get; set; }

        public List<Cars> Cars { get; set; }
     }
}
