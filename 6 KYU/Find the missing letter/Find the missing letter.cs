using System;

public class Kata
{
    public static char FindMissingLetter(char[] array)
    {   
        for (int i =0 ; i < array.Length; i++)
        {
            if( (int)array[i]+2  == (int)array[i+1] )
                return Convert.ToChar(array[i]+1);
        }   
        return '*';
    }
}