using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IDeployment:IBase
    {
        ICollection<IVersion> Version { get; set; }
        bool Successful { get; set; }
        bool InProgress { get; set; }

    }
}
