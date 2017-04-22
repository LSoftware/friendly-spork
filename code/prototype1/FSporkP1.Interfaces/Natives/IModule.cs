using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IModule:IBase,IContextual
    {
        IApplication ParentAppliation { get; set; }
        IType ModuleType { get; set; }
    }
}
