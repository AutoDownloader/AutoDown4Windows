using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDown4WindowsLib.Sources
{
    public class IrcSource : SourceBase
    {
        IrcSettings ircSettings { get; set; }

        public override void Initialize(SourceSettings settings)
        {
            base.Initialize(settings);
            ircSettings = settings as IrcSettings;
        }

        public override void Connect()
        {
            
        }
      
     
    }

    public class IrcSettings : SourceSettings
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Channel { get; set; }
        public List<string> Commands { get; set; }
    }
}
