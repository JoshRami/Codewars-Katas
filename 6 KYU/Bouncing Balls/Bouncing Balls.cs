using System;
public class BouncingBall 
{	
	public static int bouncingBall(double h, double bounce, double window) 
    {		      
      int ntimes = 0;
      
	    if (!(h > 0.0 && (bounce > 0.0 & bounce < 1.0) && window < h))
            return -1;            
        if(Math.Round(h*bounce) <= window)
            return 1;
            
      h *= bounce;
      while(h >= window)
      {
        ntimes += 2;
        h *= bounce;
      }
            
      return ntimes + 1;
   }
}