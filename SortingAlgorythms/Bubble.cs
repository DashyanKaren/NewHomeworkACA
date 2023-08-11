using System;

public class BubbleSort
{
	public BubbleSort()
	{
	}
	public int[] Sort(int[] arr)
	{
		int temp;
		for (int i = 0; i < arr.Length; i++)
		{
			for ( int j = 0; j < arr.Length-1; j++)
			{
				if (arr[j] > arr[j+1])
				{
					temp = arr[j];
					arr[j] = arr[j+1];
					arr[j+1] = temp;
				}
			}
		}


		return arr;
	
	}
}
