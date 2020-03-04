using System.Linq;
public class Kata
{
  public static int[] TwoSum(int[] numbers, int target)
  {
    int index1 = 0;
    int index2 = 0; 
    int[] indexes = new int[2];
    for(int i = 0; i < numbers.Length; i++)
    {
       index1 = numbers[i]; 
       for(int j = i + 1; j < numbers.Length; j ++)
       {
           index2 = numbers[j];
           if(index1 + index2 == target)
           { 
                indexes[0] = j;
                indexes[1] = i;
           }        
       }
    }
    return indexes;
  }
}