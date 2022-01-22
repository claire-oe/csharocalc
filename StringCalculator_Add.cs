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
	/*Method to return sum of 1 or 2 numbers */	
		[Theory]
		[InlineData("1,2",3)]
		[InlineData("2,3",5)]
	  public void ReturnsSumGivenStringWithTwoCommaSeparatedNumbers(string numbers,int expectedResult)
		{
		  var calculator=new StringCalculator();
		  var result=_calculator.Add(numbers);
		  Assert.Equal(expectedResult,result);
		} 
	/* Allow the Add method handle an unknown amount of numbers */
		[Theory]
		[InlineData("1,2,3",6)]
		[InlineData("2,3,4",9)]
	  public void ReturnsSumGivenStringWithThreeCommaSeparatedNumbers(string numbers,int expectedResult)
		{
		  var result=_calculator.Add(numbers);
		  Assert.Equal(expectedResult,result);
		} 

	}
 }
