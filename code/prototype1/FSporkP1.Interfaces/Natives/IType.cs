using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IType:IBase
    {
        IType Parent { get; set; }
        IDictionary<string, IProcess> Processes { get; }
        
    }
}
