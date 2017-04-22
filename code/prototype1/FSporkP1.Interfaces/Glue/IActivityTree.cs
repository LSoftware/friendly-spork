using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSporkP1.Interfaces
{
    public interface IActivityTree
    {
        IActivity Node { get; set; }
        ICollection<IActivityTree> OnSuccess { get; }
        ICollection<IActivityTree> OnFailure { get; }
        ICollection<IActivityTree> Always { get; }
    }
}
