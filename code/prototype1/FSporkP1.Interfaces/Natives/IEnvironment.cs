using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IEnvironment:IBase, IContextual
    {
        IDictionary<IStubNode,ICollection<IDeploymentNode>> Nodes { get; }
    }
}
