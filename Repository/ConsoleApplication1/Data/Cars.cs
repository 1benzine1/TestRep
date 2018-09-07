using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Data
{
    public class Cars
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public int CarAge { get; set; }
        public YardRacers YardRacers { get; set; }

    }
}
