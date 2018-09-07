using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    delegate string Delegator(int x);
    class TestDelegate
    {
       public event Delegator MyEventHandler;

       static string mess = "get";
       
        public string a
        {
            get
            {
                return mess;
            }
            set
            {
                 mess = "set";
            }
        }
        public static string MethodDelegator(int choise)
        {
            TestDelegate td = new TestDelegate();
            string buffer = null;

            switch (choise)
            {
                case 1: return td.a;
                case 2: td.a = buffer; return mess;
                default: return "error";
            }
        }
        public string EventOn(int x)
        {
            int _x = x;
            if (MyEventHandler != null)
            {
               MyEventHandler(_x);
               return "Произошло событие " + Convert.ToString(_x);
            }
            else return "события не было";
        }
    }
}
