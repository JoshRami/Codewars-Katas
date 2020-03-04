using System;

public class Kata
{
  public static char GetGrade(int s1, int s2, int s3)
  {
    var mean = (s1+s2+s3)/3;
    
    if(mean >= 90 & mean <= 100)
       return 'A';
       
    else if(mean >= 80 & mean < 90)
       return 'B';
    
    else if(mean >= 70 & mean < 80)
       return 'C';
    
    else if(mean >= 60 & mean < 70)
       return 'D';
       
    return 'F';
  }
}