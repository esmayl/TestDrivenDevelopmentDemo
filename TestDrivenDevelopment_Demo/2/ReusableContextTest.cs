using Xunit;
using Xunit.Abstractions;

namespace TestDrivenDevelopment_Demo;

public class ReusableContextTest : IClassFixture<CodeToPassTest.FloatGenerator>
{
    readonly ITestOutputHelper consoleOutputHelper;
    readonly CodeToPassTest.FloatGenerator injectedFloatGenerator;
    readonly float initialGeneratedFloat;
    
    public ReusableContextTest(ITestOutputHelper consoleOutputHelper, CodeToPassTest.FloatGenerator injectedFloatGenerator)
    {
        this.consoleOutputHelper = consoleOutputHelper;
        this.injectedFloatGenerator = injectedFloatGenerator;
        
        initialGeneratedFloat = injectedFloatGenerator.GetGeneratedInt();
    }
    
    [Fact]
    public void ContextShouldNotChangeAfterInit()
    {
        consoleOutputHelper.WriteLine($"Generated int: {injectedFloatGenerator.GetGeneratedInt()}");
        
        Assert.Equal(injectedFloatGenerator.GetGeneratedInt(),initialGeneratedFloat);
    }
    
    [Fact]
    public void ContextShouldNotChangeAfterInit2()
    {
        consoleOutputHelper.WriteLine($"Generated int: {injectedFloatGenerator.GetGeneratedInt()}");
        
        Assert.Equal(injectedFloatGenerator.GetGeneratedInt(),initialGeneratedFloat);
    }
    
    [Fact]
    public void ContextShouldNotChangeAfterInit3()
    {
        consoleOutputHelper.WriteLine($"Generated int: {injectedFloatGenerator.GetGeneratedInt()}");
        
        Assert.Equal(injectedFloatGenerator.GetGeneratedInt(),initialGeneratedFloat);
    }
}