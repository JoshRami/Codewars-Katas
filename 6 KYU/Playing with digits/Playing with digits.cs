using System;
public class DigPow 
{
    public static long digPow(int n, int p)
    {
        int result = 0;
        var to_char = n.ToString().ToCharArray();
       
        foreach(var i in to_char)
        {
            result += (int) Math.Pow(Char.GetNumericValue(i),p);
            p++;
        }
        return result % n == 0 ? result/n : -1 ;      
	}
}