using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

public static class SumOfK 
{
    public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
    {
        return k == 0 ? new[] { new T[0] } :
            elements.SelectMany((e, i) =>
            elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));
    }
    
    public static int? chooseBestSum(int maxDistance, int amountCountry, List<int> ts)
    {
        var result = Combinations(ts, amountCountry).ToList();
        result.RemoveAll(n => n.ToList().Sum() > maxDistance);
        if (!result.Any())
            return null;
        else
            return result.Select(m => m.Sum()).Max();
    }
      
      
        
        
    
}