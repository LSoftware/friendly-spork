using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IRelease:IBase
    {
        ICollection<IApplication> Applications { get; }
        ICollection<IVersion> Versions { get; }
    }
}
