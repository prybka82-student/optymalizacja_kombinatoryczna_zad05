using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie05
{
    public interface ISolver<T>
    {
        Task<T> SolveAsync(IEnumerable<T> sequence);
    }
}
