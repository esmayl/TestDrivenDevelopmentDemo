using Xunit;
using Xunit.Abstractions;

namespace TestDrivenDevelopment_Demo;

public class NonReusableContext
{
    readonly ITestOutputHelper consoleOutputHelper;
    readonly CodeToPassTest.FloatGenerator floatGenerator;
    readonly float initialGeneratedInt;
    
    public NonReusableContext(ITestOutputHelper consoleOutputHelper)
    {
        this.consoleOutputHelper = consoleOutputHelper;
        this.floatGenerator = new CodeToPassTest.FloatGenerator();
        
        initialGeneratedInt = floatGenerator.GetGeneratedInt();
    }
    
    [Fact]
    public void ContextShouldNotChangeAfterInit()
    {
        consoleOutputHelper.WriteLine($"Generated int: {floatGenerator.GetGeneratedInt()}");
        
        Assert.Equal(floatGenerator.GetGeneratedInt(),initialGeneratedInt);
    }
    
    [Fact]
    public void ContextShouldNotChangeAfterInit2()
    {
        consoleOutputHelper.WriteLine($"Generated int: {floatGenerator.GetGeneratedInt()}");
        
        Assert.Equal(floatGenerator.GetGeneratedInt(),initialGeneratedInt);
    }
    
    [Fact]
    public void ContextShouldNotChangeAfterInit3()
    {
        consoleOutputHelper.WriteLine($"Generated int: {floatGenerator.GetGeneratedInt()}");
        
        Assert.Equal(floatGenerator.GetGeneratedInt(),initialGeneratedInt);
    }
}