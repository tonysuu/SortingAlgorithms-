using System;

public class QuickSort
{
    public static void Main(String [] args)
    {
        int [] array = {1,5,2,4,3};
        Compute(array,0,array.Length-1);
        for (int a= 0; a < array.Length; a++)
        {
            Console.WriteLine(array[a]);
        }
    }
    public static int[] Compute (int [] array, int i, int j)
    {
        if (i < j)
        {
            int k = Split (array, i, j);
            if (k > 1)
            {
                Compute (array, i, k - 1);
            }
            if (k + 1 < j)
            {
                Compute (array, k + 1, j);
            }
        }
        return array;
    }


    public static int Split (int [] array, int i, int j)
    {
        do
        {
            int k;
            for (k = array [i] ; array [i] < k ; i++)
                ;
            for (; array [j] > k ; j--)
                ;
            if (i < j)
            {
                int l = array [j];
                array [j] = array [i];
                array [i] = l;
            }
            else
            {
                return j;
            }
        }
        while (true);
    }
}
//sort a list of numbers in ascending order
