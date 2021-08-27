using Xunit;
public class FizzbuzzTests
{
	[Fact]
	public void shouldReturnFizz()
	{
		Assert.Equal("Fizz", Fizzbuzz.execute(9));
	}

	[Fact]
	public void shouldReturnBuzz()
	{
		Assert.Equal("Buzz", Fizzbuzz.execute(25));
	}

	[Fact]
	public void shouldReturnFizzBuz()
	{
		Assert.Equal("FizzBuzz", Fizzbuzz.execute(15));
	}

	[Fact]
	public void shouldReturnNumber()
	{
		Assert.Equal("4", Fizzbuzz.execute(4));
	}

}