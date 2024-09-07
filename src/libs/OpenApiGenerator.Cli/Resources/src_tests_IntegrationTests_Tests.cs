namespace $SolutionName$.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public $ApiName$ GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("$SolutionNameUppercase$_API_KEY") ??
            throw new AssertInconclusiveException("$SolutionNameUppercase$_API_KEY environment variable is not found.");

        var api = new $ApiName$(apiKey);
        
        return api;
    }
}
