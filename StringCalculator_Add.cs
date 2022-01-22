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
	 /* Allow the Add method to handle new lines between numbers (in addition to commas).*/
		[Theory]
		[InlineData("1\n2,3",6)]
		[InlineData("1\n2\n3",6)]
		[InlineData("1,2\n3",6)]
	  public void ReturnsSumGivenStringWithThreeCommaOrNewlineSeparatedNumbers(string numbers,int expectedResult)
		{
		  var result=_calculator.Add(numbers);
		  Assert.Equal(expectedResult,result);
		}
 	/* Support different delimiters */
 		[Theory]
		[InlineData("//;\n1;2;3",6)]
	  public void ReturnsSumGivenStringWithCustomDelimiter(string numbers,int expectedResult)
		{
		  var result=_calculator.Add(numbers);
		  Assert.Equal(expectedResult,result);
		}  
	/*Calling Add for a negative number will throw an exception "negatives not allowed" - and the negative */
	/*that was passed, if there are multiple negatives, show all of them in the exception message*/
		[Theory]
		[InlineData("-1,2","Negatives not allowed:-1")]
		[InlineData("-1,-2","Negatives not allowed:-1,-2")]
	  public void ThrowsGivenNegativeInputs(string numbers,string expectedMessage)
		{
		  Action action=()=>_calculator.Add(numbers);
		  var ex=Assert.Throws<Exception>(action);
		  Assert.Equal(expectedMessage,ex.Message);
		}  
	/* Numbers bigger than 1000 would be ignored, so adding 2 + 1001 = 2 */
		[Theory]
		[InlineData("1,2,3000",3)]
		[InlineData("1001,2",2)]
		[InlineData("1000,2",1002)]
	  public void ReturnsSumGivenStringIgnoringValuesOver1000(string numbers,int expectedResult)
		{
		  var result=_calculator.Add(numbers);
		  Assert.Equal(expectedResult,result);
		} 

	}
 }
