using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IStorage:IBase
    {
        void Store(string key, string version, string data);
        string Retrieve(string key, string version);
    }
}
