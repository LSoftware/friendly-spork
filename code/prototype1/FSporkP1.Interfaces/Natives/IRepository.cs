using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IRepository:IBase
    {
        void Store(string key, string version, object artifact);
        object Retrieve(string key, string version);
    }
}
