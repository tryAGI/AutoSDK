/*
order: 10
title: Generate
slug: generate

Basic example showing how to create a client and make a request.
*/

namespace $SolutionName$.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Generate()
    {
        using var client = GetAuthenticatedClient();
    }
}
