namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        var split = input.Split(' '); 
        return string.Concat(split);
    }  
  }
}