using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie05
{
    public class Solver : ISolver<long>
    {
        public async Task<long> SolveAsync(IEnumerable<long> sequence)
        {
            return await Task.Run(() => FindSmallest(sequence));
        }

        private long FindSmallest(IEnumerable<long> sequence)
        {
            var sortedSequence = sequence.OrderBy(x => x);

            var res = 1L;

            for (long i = 0; i < sequence.Count() && sequence.ElementAt((int)i) <= res; i++)
            {
                res = res + sequence.ElementAt((int)i);
            }

            return res;
        }

        
    }
}
