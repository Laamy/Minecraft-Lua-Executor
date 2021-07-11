using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaamiStore_LExecutor.LuaEnviroment.Services
{
    class Game
    {
        public ServiceObj GetService(string serviceName)
        {
            //if (serviceName == "LocalPlayer")
                //return new LocalPlayer(...);

            return new ServiceObj("EmptyServive", "v0.0.0.0");
        }
    }
}
