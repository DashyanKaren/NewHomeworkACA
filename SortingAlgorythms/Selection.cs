using System;

public class Selection
{
	public int[] Sort(int[] arr)
	{
		int temp;
		int min;
		for (int i = 0; i < arr.Length-1; i++)
		{
			for (int j = i+1; j < arr.Length-1; j++)
			{
				if (arr[j] < arr[j + 1])
				{
					min = arr[j];
				}
				else min= arr[j+1];
				if (arr[i]>min)
				{
					temp= arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}
		}
		return arr;
	}
}
