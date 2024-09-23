namespace $SolutionName$.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static $ClientName$ GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("$SolutionNameUppercase$_API_KEY") ??
            throw new AssertInconclusiveException("$SolutionNameUppercase$_API_KEY environment variable is not found.");

        var client = new $ClientName$(apiKey);
        
        return client;
    }
}
