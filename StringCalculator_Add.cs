using System;
using Xunit;
namespace StringCal
{
	pubic class StringCalculator_Add
	{
	  private StringCalculator_calculator=new StringCalculator();
	/*For an empty string it will return 0 */
	  [Fact]
	  public void Returns0GivenEmptyString()
		{
		  var calculator=new StringCalculator();
		  var result=_calculator.Add("");
		  Assert.Equal(0,result);
		}
   	/*Method to return sum of 1 number*/
		[Theory]
		[InlineData("1",1)]
		[InlineData("2",2)]
	  public void ReturnsNumberGivenStringWithOneNumber(string numbers,int expectedResult)
		{
		  var calculator=new StringCalculator();
		  var result=_calculator.Add(numbers);
		  Assert.Equal(expectedResult,result);
		}

	

	}
 }
