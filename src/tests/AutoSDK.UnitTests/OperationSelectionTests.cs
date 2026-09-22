using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class OperationSelectionTests
{
    private const string Spec = """
openapi: 3.0.3
info:
  title: Selected API
  version: 1.0.0
paths:
  /alpha:
    get:
      operationId: listAlpha
      tags: [alpha]
      security:
        - alphaKey: []
      responses:
        '200':
          description: OK
          headers:
            X-RateLimit:
              $ref: '#/components/headers/RateLimit'
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/AlphaResponse'
        '400':
          description: Bad request
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/ErrorResponse'
  /alpha/{id}:
    post:
      operationId: updateAlpha
      tags: [alpha]
      security:
        - alphaKey: []
      parameters:
        - name: id
          in: path
          required: true
          schema:
            type: string
      requestBody:
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/SharedModel'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedModel'
  /beta:
    get:
      operationId: listBeta
      tags: [beta]
      security:
        - betaKey: []
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/BetaResponse'
components:
  schemas:
    AlphaResponse:
      type: object
      properties:
        shared:
          $ref: '#/components/schemas/SharedModel'
        variant:
          oneOf:
            - $ref: '#/components/schemas/VariantA'
            - $ref: '#/components/schemas/VariantB'
          discriminator:
            propertyName: kind
            mapping:
              a: '#/components/schemas/VariantA'
              b: '#/components/schemas/VariantB'
    VariantA:
      type: object
      properties:
        kind:
          type: string
        a:
          type: string
    VariantB:
      type: object
      properties:
        kind:
          type: string
        b:
          type: string
    ErrorResponse:
      type: object
      properties:
        message:
          type: string
    SharedModel:
      type: object
      properties:
        value:
          type: string
    BetaResponse:
      type: object
      properties:
        beta:
          type: string
    UnusedModel:
      type: object
      properties:
        unused:
          type: string
  securitySchemes:
    alphaKey:
      type: apiKey
      in: header
      name: X-Alpha-Key
    betaKey:
      type: apiKey
      in: header
      name: X-Beta-Key
  headers:
    RateLimit:
      description: Remaining requests
      schema:
        type: integer
""";

    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "G",
        ClassName = "ApiClient",
        TargetFramework = "net10.0",
        GenerateSdk = true,
        GenerateModels = true,
        GenerateMethods = true,
        FromCli = true,
        JsonSerializerContext = "G.SourceGenerationContext",
        GenerateJsonSerializerContextTypes = true,
    };

    [TestMethod]
    public void WithoutSelectors_KeepsTheFullSurface()
    {
        var data = Prepare(DefaultSettings);

        data.Methods.Should().HaveCount(3);
        data.Classes.Select(x => x.ClassName).Should().Contain("BetaResponse").And.Contain("UnusedModel");
    }

    [TestMethod]
    public void IncludeTag_PrunesUnrelatedOperationsAndSchemas()
    {
        var data = Prepare(DefaultSettings with { IncludeTags = ["alpha"] });

        data.Methods.Select(x => x.Id).Should().BeEquivalentTo("ListAlpha", "UpdateAlpha");
        data.Classes.Select(x => x.ClassName).Should().Contain("AlphaResponse").And.Contain("SharedModel")
            .And.Contain("VariantA").And.Contain("VariantB").And.Contain("ErrorResponse");
        data.Classes.Select(x => x.ClassName).Should().NotContain("BetaResponse").And.NotContain("UnusedModel");
        data.Authorizations.Select(x => x.SchemeId).Should().Contain("AlphaKey").And.NotContain("BetaKey");
        data.Methods.Single(x => x.Id == "ListAlpha").SuccessResponse.HasHeaders.Should().BeTrue();
    }

    [TestMethod]
    public void IncludeDimensions_IntersectAndKeepSharedDependencies()
    {
        var data = Prepare(DefaultSettings with
        {
            IncludePaths = ["/alpha"],
            IncludeOperationIds = ["listAlpha"],
            IncludeTags = ["alpha"],
        });

        data.Methods.Should().ContainSingle().Which.Id.Should().Be("ListAlpha");
        data.Classes.Select(x => x.ClassName).Should().Contain("AlphaResponse").And.Contain("SharedModel");
        data.Classes.Select(x => x.ClassName).Should().NotContain("BetaResponse").And.NotContain("UnusedModel");
    }

    [TestMethod]
    public void IncludeTag_SelectsAnOperationWhenTheTagIsNotFirst()
    {
        var yaml = Spec.Replace(
            "components:\n  schemas:",
            "  /both:\n    get:\n      operationId: listBoth\n      tags: [beta, alpha]\n      responses:\n        '200':\n          description: OK\n          content:\n            application/json:\n              schema:\n                $ref: '#/components/schemas/SharedModel'\ncomponents:\n  schemas:",
            StringComparison.Ordinal);
        var settings = DefaultSettings with { IncludeTags = ["alpha"] };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));

        data.Methods.Select(x => x.Id).Should().Contain("ListBoth");
        data.Tags.Select(x => x.Name).Should().Contain("beta").And.Contain("alpha");
    }

    [TestMethod]
    public void ExcludeTag_RemovesItsOperationAndPrivateModel()
    {
        var data = Prepare(DefaultSettings with { ExcludeTags = ["beta"] });

        data.Methods.Select(x => x.Id).Should().NotContain("ListBeta");
        data.Classes.Select(x => x.ClassName).Should().NotContain("BetaResponse");
    }

    [TestMethod]
    public void ExcludePathAndOperationId_RemoveTheirOperations()
    {
        var data = Prepare(DefaultSettings with
        {
            ExcludePaths = ["/beta"],
            ExcludeOperationIds = ["updateAlpha"],
        });

        data.Methods.Should().ContainSingle().Which.Id.Should().Be("ListAlpha");
        data.Classes.Select(x => x.ClassName).Should().Contain("SharedModel").And.NotContain("BetaResponse");
    }

    [TestMethod]
    public void MissingSelector_ReportsTheUnmatchedValue()
    {
        Action generate = () => Prepare(DefaultSettings with { IncludePaths = ["/missing"] });

        generate.Should().Throw<ArgumentException>().WithMessage("*path selector '/missing' matched no operations*");
    }

    [TestMethod]
    public void SelectedOperation_TraversesReferencesBeyondTwentyLevels()
    {
        var securityOffset = Spec.IndexOf("  securitySchemes:", StringComparison.Ordinal);
        var builder = new System.Text.StringBuilder(Spec.Substring(0, securityOffset).Replace(
            "#/components/schemas/AlphaResponse",
            "#/components/schemas/Deep0",
            StringComparison.Ordinal));
        for (var index = 0; index < 32; index++)
        {
            builder.AppendLine($"    Deep{index}:");
            builder.AppendLine("      type: object");
            builder.AppendLine("      properties:");
            builder.AppendLine("        value:");
            builder.AppendLine("          type: string");
            if (index < 31)
            {
                builder.AppendLine("        next:");
                builder.AppendLine($"          $ref: '#/components/schemas/Deep{index + 1}'");
            }
        }
        builder.Append(Spec.Substring(securityOffset));

        var settings = DefaultSettings with { IncludePaths = ["/alpha"] };
        var data = AutoSDK.Generation.Data.Prepare(((builder.ToString(), settings), settings));

        data.Classes.Select(x => x.ClassName).Should().Contain("Deep31");
    }

    [TestMethod]
    public void SelectedOperation_RetainsItsCallbackButNotAnUnrelatedWebhook()
    {
        var yaml = TestSpecCache.GetText("callbacks-webhooks-links.yaml");
        var settings = DefaultSettings with { IncludePaths = ["/subscriptions"] };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));

        data.Methods.Select(x => x.Id).Should().Contain("CreateSubscription").And.NotContain("GetSubscriptionStatus");
        data.Classes.Select(x => x.ClassName).Should().Contain("SubscriptionStatusCallbackRequest");
        data.Classes.Select(x => x.ClassName).Should().NotContain("SubscriptionUpdatedWebhookRequest");
    }

    private static AutoSDK.Models.Data Prepare(Settings settings)
    {
        return AutoSDK.Generation.Data.Prepare(((Spec, settings), settings));
    }
}
