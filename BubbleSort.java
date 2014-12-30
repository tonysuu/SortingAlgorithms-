import hsa.*;

public class BubbleSort {
    public static void main(String [] args){
        int array [] = {1,5,3,2,9};
        Bsort(array);
    }
    public static void Bsort(int [] array)
    {
        int temp = 0;
        for (int i = array.length-1; i >= 0; i--)
        {
            for (int a = 0; a < i; a++)
            {
                if (array[a] > array[a+1])
                {
                    temp = array[a];
                    array[a] = array[a+1];
                    array[a+1] = temp;
                }
            }
        }
        for (int i = 0; i < array.length; i++)
        {
            System.out.println(array[i]);
        }
    }
}
//sort a list of numbers in ascending order.
