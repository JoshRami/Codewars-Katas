using System;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        int duplicates = 0;
        string looked = string.Empty;
        str = str.ToUpper();

        foreach(var j in str)
        {
            if(!looked.Contains(j))
                looked += j;
        }
        for (int i = 0; i < looked.Length; i++)
        {
            if (AppearsMoreThanOnce(str,looked[i]))
                duplicates++;
        }
        return duplicates;
    }

    public static bool AppearsMoreThanOnce(string check, char ch)
    {
        int ntimes = 0;
        for (int i = 0; i < check.Length; i++)
        {
            if (ch == check[i])
                ntimes++;
        }
        return ntimes > 1 ? true : false;
    }
}