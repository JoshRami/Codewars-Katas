using System;
using System.Linq;

public class IQ
{
    public static int Test(string numbers)
    { 
        var Numbers = numbers.Split(' ');
        int AreEven = 0;
        int result = 0;     

        //Defines if the numbers  it's composed of evens     
        for(int i = 0; i <= Numbers.Length-1; i++)
        {
            if(int.Parse(Numbers[i]) % 2 == 0)
                AreEven++;
        }

        if(AreEven > 1)       //If it's true, the numbers are compose of even numbers          
        {
            for(int i = 0; i <= Numbers.Length-1; i++)
            {
                if(int.Parse(Numbers[i]) % 2 != 0)
                   result = i;  
            }
        }     
        else                 //Numbers are composed of odds numbers
        {
            for(int i = 0; i <= Numbers.Length-1; i++)
            {
                if(int.Parse(Numbers[i]) % 2 == 0)
                     result = i;                
            }
        }
             
        return ++result;
    }
}