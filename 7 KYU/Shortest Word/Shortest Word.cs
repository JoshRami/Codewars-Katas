public class Kata
{
  public static int FindShort(string s)
  {
   var words = s.Split(' ');
   int Minlength = words[0].Length;

   for(int i = 1; i <= words.Length-1;i++)
   {
     if(words[i].Length <Minlength)
        Minlength = words[i].Length;
   }

   return Minlength; 
  }
}