using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaamiStore_LExecutor.LuaEnviroment
{
    class ServiceObj
    {
        public string name;
        public string version;

        public ServiceObj(string name, string version)
        {
            this.name = name;
            this.version = version;
        }
    }
}
