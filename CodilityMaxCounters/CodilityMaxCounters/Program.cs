using System;

namespace CodilityMaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] a = new int[7] { 3, 4, 4, 6, 1, 4, 4 };

            Solution s = new Solution();
            s.solution(n, a);

            Console.ReadLine();
        }
    }
}
