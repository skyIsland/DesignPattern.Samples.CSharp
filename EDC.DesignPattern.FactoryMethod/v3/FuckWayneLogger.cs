using EDC.DesignPattern.FactoryMethod.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.FactoryMethod.v3
{
    public class FuckWayneLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("this is FuckWayneLogger");
        }
    }
}
