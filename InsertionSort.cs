using System;

public class InsertionSort {
	public static void Main()
	{
		int [] array = {5,2,3,1,4};
		Sort(array);
	}
	public static void Sort(int [] array)
	{
		for (int i = 1; i < array.Length;i++)
		{
			int temp = array[i];
			int a = i;
			while (a > 0)
			{
				if (temp > array[a-1])
				{
					a--;
					break;
				}
				else
				{
					int temp1 = array[a-1];
					array [a-1] = temp;
					array[a]= temp1;
				}
				a--;
			}
		}
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	}
}
//sort a list of numbers in ascending order.
