using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IContext
    {
        IContext Parent { get; set; }
        object this[string key] { get;set; }
    }
}
