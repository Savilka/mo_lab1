using System;

namespace mo_lab1
{
    class Program
    {
        private static void Main(string[] args) {
            OneDimensionalSearchMethods.Dichotomy(1.0E-7f);
            OneDimensionalSearchMethods.GoldenSectionSearch(1.0E-7f);
            OneDimensionalSearchMethods.Fibonacci(1.0E-7f);
            OneDimensionalSearchMethods.SearchInterval(8,0.1);
        }
    }
}