using Xunit;

namespace TestDrivenDevelopment_Demo;

[CollectionDefinition("Context collection")]
public class ContextCollectionDefinition : ICollectionFixture<CodeToPassTest.Context>{}