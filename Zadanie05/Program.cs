using System;
using System.Threading.Tasks;

namespace Zadanie05
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var runner = new Runner();

            await runner.RunAsync(new Solver());

            //przykladowe ciągi
            int[] arr1 = { 1, 3, 4, 5 }; //
            int[] arr2 = { 1, 2, 6, 10, 11, 15 };
            int[] arr3 = { 1, 1, 1, 1 };
            int[] arr4 = { 1, 1, 3, 4 };
            int[] arr5 = {1, 1, 2, 9};

        }
    }
}
