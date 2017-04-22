using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IApplication:IBase
    {
        ICollection<IModule> Modules { get; }
        IType ApplicationType { get; set; }
        
    }
}
