using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class ExtendedMoniter
    {
        private ILogger logger; //메서드 logger

        public ExtendedMoniter(ILogger logger)  //매개변수 logger
        {
            this.logger = logger;
        }

        public void PrintLog(string message)
        {
            this.logger.WriteLog(message);
        }
    }
}
