using System;
using Xunit;
namespace StringCLass
{
	pubic class StringCalculator
	{
	 
	internal object Add(string numbers)
	  {
	/*For an empty string */
	if(String.IsNullorEmpty(numbers)) return 0;
    
       /*To Split 2 numbers*/
	var delimiters=new List<char>{',',\n};
		string numberString=numbers;
    
	/* Support different delimiters */
		if(numberString.StartsWith("//"))
		{
			var splitInput=numberString.Split('\n');
			var newDelimiter=splitInput.First().Trim('/');
			numberString=String.Join('\n',splitInput.Skip(1));
			delimiters.Add(Convert.ToChar(newDelimiter));
		}
		
		var numberList=numberString.Split(delimiters.ToArray()).Select(s=>int.Parse(s));
		
		var negatives=numberList.Where(n=>n<0);
			 if(negative.Any())
			  {
			  string negativeString=String.Join(',',negative.Select(n=>n.ToString()));
				throw new Exception($"Negative not allowed:{negativeString}");
			   }
    
			var result=numberList.Where(n=>n<=1000).Sum();
			return result;
	   }
	}
}
