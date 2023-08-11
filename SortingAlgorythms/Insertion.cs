using System;

public class Insertion
{
	public int[] Sort(int[] arr) 
	{
		int temp;
		for (int i = 1; i < arr.Length; i++)
		{
			for (int j = i; j > 0; j--)
			{
				if (arr[j] < arr[j - 1]) 
				{
					temp = arr[j];
					arr[j] = arr[j - 1];
					arr[j - 1] = temp;
				} ;
			}
		}
		return arr;
	}
}
