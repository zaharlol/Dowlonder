using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dowlonder
{
    internal class CommandTwo : Command
    {
        Dowland dowland;
        public CommandTwo(Dowland _dowland) 
        {
            dowland = _dowland;
        }

        public override void Cancel() { }

        public override void Run()
        {
            dowland.DownloadAsync().Wait();
        }
    }
}
