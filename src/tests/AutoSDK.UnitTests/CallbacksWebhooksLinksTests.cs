using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class CallbacksWebhooksLinksTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "G",
        ClassName = "Api",
        TargetFramework = "net8.0",
        GenerateSdk = true,
        GenerateModels = true,
        GenerateMethods = true,
    };

    [TestMethod]
    public void Prepare_RetainsCallbackAndWebhookSchemas_WithoutGeneratingOutboundMethods()
    {
        var yaml = TestSpecCache.GetText("callbacks-webhooks-links.yaml");
        var settings = DefaultSettings;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Classes.Select(x => x.ClassName).Should().Contain("SubscriptionStatusCallbackRequest");
        data.Classes.Select(x => x.ClassName).Should().Contain("SubscriptionUpdatedWebhookRequest");

        data.Schemas
            .Where(x => x.Parent == null && x.Hint == Hint.Request)
            .Select(x => x.OperationPath)
            .Should()
            .Contain("{$request.body#/callbackUrl}")
            .And.Contain("subscription.updated");

        data.Methods.Should().HaveCount(2);
        data.Methods.Select(x => x.Id).Should().Contain("CreateSubscription");
        data.Methods.Select(x => x.Id).Should().Contain("GetSubscriptionStatus");
    }

    [TestMethod]
    public void HttpArtifacts_ExposeCallbacksLinksAndWebhooks()
    {
        var yaml = TestSpecCache.GetText("callbacks-webhooks-links.yaml");
        var settings = (CSharpSettings)DefaultSettings;

        var document = yaml.GetOpenApiDocument(settings);
        var schemas = document.GetSchemas(settings);
        var operations = document.GetOperations(settings, globalSettings: settings, filteredSchemas: schemas);
        var webhookOperations = document.GetWebhookOperations(settings, globalSettings: settings, filteredSchemas: schemas);

        var httpFile = Sources.GenerateHttpFile("subscriptions", operations);
        var webhooksFile = Sources.GenerateWebhookHttpFile(webhookOperations);

        httpFile.Should().Contain("## Links");
        httpFile.Should().Contain("# 201.subscriptionStatus");
        httpFile.Should().Contain("# OperationId: getSubscriptionStatus");
        httpFile.Should().Contain("# Parameters.subscriptionId: $response.body#/id");
        httpFile.Should().Contain("## Callbacks");
        httpFile.Should().Contain("### [CALLBACK] Receive subscription status");
        httpFile.Should().Contain("# Name: subscriptionStatus");
        httpFile.Should().Contain("# Target: {$request.body#/callbackUrl}");
        httpFile.Should().Contain("\"subscriptionId\": \"string\"");
        httpFile.Should().Contain("\"state\": \"string\"");

        webhooksFile.Should().Contain("### [WEBHOOK] Subscription updated webhook");
        webhooksFile.Should().Contain("# Name: subscription.updated");
        webhooksFile.Should().Contain("# Method: POST");
        webhooksFile.Should().Contain("\"event\": \"string\"");
        webhooksFile.Should().Contain("\"id\": \"string\"");
        webhooksFile.Should().Contain("\"state\": \"string\"");
    }
}
