using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie05
{
    public class Solver : ISolver<int>
    {
        public async Task<int> SolveAsync(IEnumerable<int> sequence)
        {
            return await Task.Run(() => FindSmallest(sequence));
        }

        private int FindSmallest(IEnumerable<int> sequence)
        {
            var sortedSequence = sequence.OrderBy(x => x);

            var res = 1;

            for (int i = 0; i < sequence.Count() && sequence.ElementAt(i) <= res; i++)
            {
                res = res + sequence.ElementAt(i);
            }

            return res;
        }

        
    }
}
