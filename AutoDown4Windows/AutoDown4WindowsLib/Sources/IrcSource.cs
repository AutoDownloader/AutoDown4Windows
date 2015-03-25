using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDown4WindowsLib.Sources
{
    public class IrcSource : SourceBase
    {
     
    }

    public class IrcSettings : SourceSettings
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
    }
}
