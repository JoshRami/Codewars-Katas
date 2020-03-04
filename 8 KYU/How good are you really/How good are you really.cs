using System.Linq;
public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    return ClassPoints.Sum()/ClassPoints.Length > YourPoints ? false : true;
  }
}