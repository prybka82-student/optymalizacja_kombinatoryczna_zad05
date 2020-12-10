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

            //przykladowe ciagi
            int[] arr1 = { 1, 3, 4, 5 }; //wynik: 2
            int[] arr2 = { 1, 2, 6, 10, 11, 15 }; //wynik: 4
            int[] arr3 = { 1, 1, 1, 1 }; //wynik: 5
            int[] arr4 = { 1, 1, 3, 4 }; //wynik: 10
            int[] arr5 = {1, 1, 2, 9}; //wynik: 5

            //algorytm i przykladowe implementacje
            //https://www.geeksforgeeks.org/find-smallest-value-represented-sum-subset-given-array/

            //zadanie
            //https://gitlab.com/wojtek3dan/zadania-to/-/blob/master/zadania.md

        }
    }
}
