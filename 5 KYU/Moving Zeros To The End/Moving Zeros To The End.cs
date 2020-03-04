using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int index = 0;
	var Sort = new List<int>();
		
	for(int i = 0; i < arr.Length; i++)
	{
		if(arr[i] == 0)
			index++;
		else
			Sort.Add(arr[i]);
	}
			
	for(int i = 0 ; i < index; i++)
	{
		Sort.Add(0);
	}
    
	return Sort.ToArray();
  }
}