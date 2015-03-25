using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDown4WindowsLib.Sources
{
    public interface ISource
    {
        void Initialize(SourceSettings settings);
    }
}
