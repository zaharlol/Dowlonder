using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dowlonder
{
    internal class CommandOne : Command
    {
        GetInfo getInfo;
        public CommandOne(GetInfo _getInfo) 
        {
            getInfo = _getInfo;
        }

        public override void Cancel() { }

        public override void Run()
        {
            getInfo.GetAsync().Wait();
        }
    }
}
