using System;
using System.Collections.Generic;

namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
    {
        var nonrepeating = new List<int>();
        int odd = 0;
        int Ntimes = 0;
        
        foreach(var i in seq)
        {
            if(!nonrepeating.Contains(i))
                nonrepeating.Add(i);
        }
        for(int i = 0; i < Nonrepeating.Count; i++)
        {
            odd = Nonrepeating[i];
            for(int j = 0; j < seq.Length; j++)
            {
                if(odd == seq[j])
                    Ntimes++;
            }
          
            if(Ntimes % 2 != 0)
                return odd;
            else
                Ntimes = 0;
        }
       
       return odd;
    }
       
  }
}