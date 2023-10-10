using Xunit;

namespace TestDrivenDevelopment_Demo;

[CollectionDefinition("FloatGenerator collection")]
public class ContextCollectionDefinition : ICollectionFixture<CodeToPassTest.FloatGenerator>{}