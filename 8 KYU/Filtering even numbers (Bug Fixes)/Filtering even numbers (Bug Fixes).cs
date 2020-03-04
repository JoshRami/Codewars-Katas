using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        List<int> odd_numbers = new List<int>();
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i] % 2 != 0)
                odd_numbers.Add(listOfNumbers[i]);
        }
        return OddNumbers;
    }    
}