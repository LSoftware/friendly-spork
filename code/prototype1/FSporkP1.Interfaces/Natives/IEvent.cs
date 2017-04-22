using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IEvent:IBase,IContextual
    {
        IObservable EventSource { get; set; }
        object EventData { get; set; }
    }
}
