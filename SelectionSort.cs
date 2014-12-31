using System;

public class SelectionSort
{
	public static void Main()
	{
		int [] array = {5,2,4,1,3};
		Sort(array);
	}
	public static void Sort(int [] array)
	{
		int smallest = 0;
		int temp = 0;
		for (int i = 0; i < array.Length; i++)
		{
			smallest = array[i];
			for (int a = i; a < array.Length; a++)
			{
				if (array[a] <= smallest)
				{
					smallest = array[a];
					temp = a;
				}
			}
			array[temp] = array[i];
			array[i] = smallest;
		}
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	}
}	
// sort a list of numbers in ascending order
