using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDown4WindowsLib.Sources
{
    public abstract class SourceBase : ISource
    {
        SourceSettings settings { get; set; }

        public virtual void Initialize(SourceSettings settings)
        {
            this.settings = settings;
        }

        public abstract void Connect();
        
    }
}
