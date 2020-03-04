public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
       int nrepeated = 0;
	   string sToUpper = s.ToUpper();
	   char actual_char = ' ';
	   string result = "";
	
	  for(int i = 0; i< s.Length; i++)
	  {
		  actual_char = sToUpper[i];
		  nrepeated = 0;	  
		  for(int j = 0; j < s.Length; j++)
		  {
			 if(actual_char.Equals(sToUpper[j]))
				 NRepeating++;		 
		  }
		  if(NRepeating == 1) 
			 return result = s[i].ToString();		       
	  }
		return "";
  }
}