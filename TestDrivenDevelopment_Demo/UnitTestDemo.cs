using Xunit;

public class UnitTestDemo
{
    [Fact]
    public void TestWithBareFact()
    {
    }
    
    [Fact(Skip = "Skip reason here")]
    public void TestWithSkip()
    {
    }
    
    [Theory]
    [InlineData("Test string from inline data",-1)]
    [InlineData("1",1)]
    public void TestWithTheory(string testString,int expectedNumberParsed)
    {
    }
    
    [Theory]
    [MemberData(nameof(TestDataIEnumerator))]
    public void TestWithTheoryIEnumeratorData(string testString,int expectedNumberParsed)
    {
    }
    
    [Theory]
    [ClassData(typeof(TestDataAsClass))]
    public void TestWithTheoryDataAsClass(string testString,int expectedNumberParsed)
    {
    }
    
    
    public static IEnumerable<object[]> TestDataIEnumerator()
    {
        yield return new object[] { "Test string from IEnumerator data", -1 };
        yield return new object[] { "1", 1 };
    }
}