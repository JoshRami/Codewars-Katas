public static class Kata
{
  public static int Solution(int value)
  {
    int multiples = 0;  
    for(int i = value - 1; i >= 0; i--)
    {
       if(i % 3 == 0 || i % 5 == 0) 
       {
          multiples += i;
       }
    }
    return multiples;
  }
}