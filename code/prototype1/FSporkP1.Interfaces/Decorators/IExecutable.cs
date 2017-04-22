using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IExecutable:IBase
    {
        bool PreExecute(IContext context);
        bool Execute(IContext context);
        bool PostExecute(IContext context);
    }
}
