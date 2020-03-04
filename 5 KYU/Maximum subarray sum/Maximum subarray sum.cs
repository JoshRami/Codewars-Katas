using System;
using System.Collections;
using System.Linq;

public static class Kata
{
    public static int MaxSequence(int[] arr) 
    { 
        bool are_positives = true;
        bool are_negatives = true;
        int best_sum = 0;
        int current_sum = 0;   
        
        if(arr.Length == 0)
            return 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < 0)
                are_positives = false;
            if(arr[i] > 0)
                are_negatives = false;
        }
    if(are_positives)
        return arr.Sum();
    if(are_negatives)
        return 0; 
     
    for(int i = 0; i < arr.Length; i++)
    {
       current_sum = arr[i];
       for(int j = i+1; j < arr.Length; j++)
       {
        current_sum += arr[j];
        if(current_sum > best_sum)
            best_sum = current_sum;
       }
       current_sum = 0;
     }
     return best_sum;
  }
}