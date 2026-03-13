using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

public partial class NamingTests
{
    [TestMethod]
    public void SummaryMethodNames_RemoveApostrophesFromIdentifiers()
    {
        var settings = Settings.Default with
        {
            Namespace = "LangSmith",
            ClassName = "LangSmithClient",
            ClsCompliantEnumPrefix = "x",
            MethodNamingConvention = MethodNamingConvention.Summary,
        };
        var operation = new OpenApiOperation
        {
            Summary = "Get the authenticated user's Slack ID",
        };

        var context = OperationContext.FromOperation(
            settings: settings,
            globalSettings: settings,
            operation: operation,
            operationPath: "/me/slack_id",
            operationType: System.Net.Http.HttpMethod.Get,
            filteredSchemas: [],
            globalSecurityRequirements: []);
        var endPoint = EndPoint.FromSchema(context);

        context.MethodName.Should().Be("GetTheAuthenticatedUsersSlackId");
        endPoint.NotAsyncMethodName.Should().Be("GetTheAuthenticatedUsersSlackId");
        endPoint.MethodName.Should().Be("GetTheAuthenticatedUsersSlackIdAsync");
        endPoint.FileNameWithoutExtension.Should().Be("LangSmith.LangSmithClient.GetTheAuthenticatedUsersSlackId");
        endPoint.InterfaceFileNameWithoutExtension.Should().Be("LangSmith.ILangSmithClient.GetTheAuthenticatedUsersSlackId");
    }
}
