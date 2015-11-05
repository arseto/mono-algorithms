using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Algorithms
{
	class Program
	{
        enum Algorithm
        {
            FIBONACCI = 1,
            BUBBLE_SORT = 2,
            QUICK_SORT = 3,
            PASCAL_TRIANGLE = 4
        }

        enum Sorting
        {
            ASC = 1,
            DESC = 2
        }

		static void Main(string[] args)
		{
            Console.WriteLine("Choose algorithm:");
            Console.WriteLine("1. Fibonacci");
            Console.WriteLine("2. Bubble Sort");
            Console.WriteLine("3. Quick Sort");
            Console.WriteLine("4. Pascal Triangle");

            Algorithm option = TryGetAlgorithmOption();

            if (option == Algorithm.QUICK_SORT)
                QuickSortSequence();
            else if (option == Algorithm.BUBBLE_SORT)
                BubbleSortSequence();
            else if (option == Algorithm.FIBONACCI)
                FibonacciSequence();
            else if (option == Algorithm.FIBONACCI)
                FibonacciSequence();
            else if (option == Algorithm.PASCAL_TRIANGLE)
                PascalTriangleSequence();
            
            Console.ReadKey();
            Console.WriteLine("Exit");
		}

        private static void PascalTriangleSequence()
        {
            Console.WriteLine("Input the size of pascal triangle:");
            int size = TryGetIntInput();

            PascalTriangle pascal = new PascalTriangle(size);
            string[] rows = pascal.GenerateTriangleStr();

            foreach (var row in rows)
            {
                Console.WriteLine(row);
            }
        }

        private static void FibonacciSequence()
        {
            Console.WriteLine("Input start index of Fibonacci sequence:");
            int startIndex = TryGetIntInput();

            Console.WriteLine("Input end index:");
            int endIndex = TryGetIntInput();

            int[] sequence = Fibonacci.GetSeries(startIndex, endIndex);

            Console.WriteLine("Fibonacci sequence:");
            PrintArray(sequence);

        }

        private static Sorting ShowSortingOption()
        {
            Console.WriteLine("Choose sorting mode:");
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");

            Sorting opt = TryGetSortingOption();

            return opt;
        }

        private static void QuickSortSequence()
        {
            Sorting opt = ShowSortingOption();

            Console.WriteLine("Input space separated integers to sort:");

            int[] toSort = ReadInput();

            if (opt == Sorting.ASC)
                toSort = QuickSort.SortAsc(toSort);
            else
                toSort = QuickSort.SortDesc(toSort);

            Console.WriteLine("Sorted sequence:");
            PrintArray(toSort);
        }

        private static void BubbleSortSequence()
        {
            Sorting opt = ShowSortingOption();
            Console.WriteLine("Input space separated integers to sort:");

            int[] toSort = ReadInput();
            if (opt == Sorting.ASC)
                BubbleSort.SortAsc(toSort);
            else
                BubbleSort.SortDesc(toSort);

            Console.WriteLine("Sorted sequence:");
            PrintArray(toSort);
        }

        private static int TryGetIntInput()
        {
            string optStr = Console.ReadLine();
            int opt = Convert.ToInt32(optStr);

            return opt;
        }

        private static Sorting TryGetSortingOption()
        {
            int opt = TryGetIntInput();
            Sorting alg = (Sorting)opt;
            return alg;
        }

        private static Algorithm TryGetAlgorithmOption()
        {
            int opt = TryGetIntInput();
            Algorithm alg = (Algorithm)opt;
            return alg;
        }

		private static void PrintArray(int[] sorted)
		{
			Console.Write("[");
			for (int i = 0; i < sorted.Count(); i++)
			{
				Console.Write(sorted[i].ToString());
				if (i < sorted.Count() - 1) Console.Write(", ");
			}
			Console.WriteLine("]");
		}

		static int[] ReadInput()
		{
			List<int> temp = new List<int>();

			string input = Console.ReadLine();
			if (input != null)
			{
				foreach (var s in input.Split(' '))
				{
                    if(!string.IsNullOrEmpty(s))
					    temp.Add(int.Parse(s));
				}
			}

			return temp.ToArray();
		}
	}
}