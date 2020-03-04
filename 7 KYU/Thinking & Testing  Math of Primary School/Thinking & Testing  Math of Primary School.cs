namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int Testit(int[] a){
          var extremes = a[0] * a[3];
          var middles = a[1] * a[2];
          
          return middles + extremes;
        }
    }
}