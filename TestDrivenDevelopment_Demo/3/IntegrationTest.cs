using Xunit;
using Xunit.Abstractions;

namespace TestDrivenDevelopment_Demo;

[Collection("FloatGenerator collection")]
public class IntegrationTest : IDisposable
{
    readonly ITestOutputHelper consoleOutputHelper;
    readonly CodeToPassTest.FloatGenerator floatGenerator;
    readonly float initialGeneratedFloat;
    
    public IntegrationTest(ITestOutputHelper consoleOutputHelper,CodeToPassTest.FloatGenerator floatGenerator)
    {
        this.consoleOutputHelper = consoleOutputHelper;
        this.floatGenerator = floatGenerator;
        
        initialGeneratedFloat = floatGenerator.GetGeneratedInt();
    }
    
    [Fact]
    public void ContextShouldNotChangeAfterInit()
    {
        consoleOutputHelper.WriteLine($"Generated int: {floatGenerator.GetGeneratedInt()}");
        
        Assert.Equal(floatGenerator.GetGeneratedInt(),initialGeneratedFloat);
    }

    public void Dispose()
    {
        GC.Collect();
    }
}