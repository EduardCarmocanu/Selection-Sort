using System;

namespace SelectionSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] testInput = { 18, 6, 66, 44, 9, 22, 14, 18, 6, 66, 44, 9, 22, 14, 18, 6, 66, 44, 9, 22, 14 };

			Sort(testInput);

			for (int i = 0; i < testInput.Length - 1; i++)
			{
				Console.WriteLine(testInput[i]);
			}
		}

		static void Sort(int[] list)
		{
			for (int i = 0; i < list.Length - 1; i++)
			{
				Swap(list, i, FindMinIndex(list, i));
			}

			return;
		}
		static int FindMinIndex(int[] list, int from)
		{
			int min = from; 

			for (int i = from; i < list.Length - 1; i++)
			{
				if (list[i] < list[min])
				{
					min = i;
				}
			}
			return min;
		}
		static void Swap (int[] list, int firstIndex, int lastIndex)
		{
			int temp = list[firstIndex];

			list[firstIndex] = list[lastIndex];
			list[lastIndex] = temp;
		}
	}
}
