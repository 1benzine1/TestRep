using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Data
{
    class RacersRepository
    {
        public IEnumerable<YardRacers> GetAllRacers()
        {
            var context = new TestDB();

            return context.YardRacers.Include("Cars").ToList();
        }

        public void AddRacer(YardRacers item)
        {
            var context = new TestDB();

            context.YardRacers.Add(item);

            context.SaveChanges();
        }
    }
}
