namespace $SolutionName$.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Generate()
    {
        using var api = GetAuthenticatedApi();
    }
}
