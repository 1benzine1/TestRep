using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication1.Data;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Delegator del = new Delegator(TestDelegate.MethodDelegator);
            TestDelegate tsc = new TestDelegate();

            Console.WriteLine("1 get , 2 set");
            int x = Convert.ToInt32(Console.ReadLine());

            string temp = del(x);

            tsc.MyEventHandler += TestDelegate.MethodDelegator;
            Console.WriteLine("Исп делегата " + temp);
            Console.WriteLine(tsc.EventOn(x));

            var yardracers = new YardRacers{NameRacer = "Жмышенко Валерий Альбертович", 
                                                                 Birthday = DateTime.Today, Cars = new List<Cars>()};

            yardracers.Cars.Add(new Cars { CarName = "Чепырка", CarAge = 228});

            var racersrep = new RacersRepository();

            racersrep.AddRacer(yardracers);

            Console.WriteLine("\n\tУвага! Увага! Выехает гонщык: " + yardracers.NameRacer);
            Console.WriteLine("\tДень народження гинщика: " + yardracers.Birthday);

            foreach (var i in yardracers.Cars)
            Console.WriteLine("\tМодель авто ({0}), якому {1} рокив. ", i.CarName, i.CarAge);

            Console.ReadKey();

            //ClassTestInterface cti = new ClassTestInterface();
            //Console.WriteLine(cti.Testinterface(x));
        }
    }
}
 //   class ClassTestInterface : InterfaceTest
//{
        //string mess = "get";
        //public string a
        // {
        //     get 
        //     {
        //         return mess;
        //     }
        //     set 
        //     {
        //         mess = "set";
        //     }

        //public string Testinterface(int choise)
        //{
        //    string buffer = null;

        //    switch (choise)
        //    {
        //        case 1: return a;
        //        case 2: a = buffer; return mess;
        //        default: return mess = "эггог";
        //    }

        //}
  //  }


