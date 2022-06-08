using EDC.DesignPattern.FactoryMethod.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.FactoryMethod.v3
{
    public class FuckWayneLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            ILogger logger = new FuckWayneLogger();

            return logger;
        }
    }
}
