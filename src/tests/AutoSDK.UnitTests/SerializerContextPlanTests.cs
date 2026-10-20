using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Packaging;

namespace AutoSDK.UnitTests;

[TestClass]
public class SerializerContextPlanTests
{
    private const string Spec = """
openapi: 3.0.3
info:
  title: Serializer graph
  version: 1.0.0
paths:
  /first:
    post:
      operationId: first
      tags: [same]
      requestBody:
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/FirstRequest'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Shared'
  /second:
    get:
      operationId: second
      tags: [same]
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SecondResponse'
components:
  schemas:
    FirstRequest:
      type: object
      properties:
        timestamp:
          type: string
          format: date-time
        nested:
          $ref: '#/components/schemas/Shared'
        choice:
          oneOf:
            - type: string
            - type: integer
    SecondResponse:
      type: object
      properties:
        nested:
          $ref: '#/components/schemas/Shared'
        extra:
          type: string
    UnusedA:
      type: object
      properties:
        a:
          type: string
    UnusedB:
      type: object
      properties:
        b:
          type: string
    Shared:
      type: object
      properties:
        timestamp:
          anyOf:
            - type: string
              format: date
            - type: 'null'
        value:
          type: string
""";

    private static AutoSDK.Models.Data Prepare()
    {
        var settings = Settings.Default with
        {
            Namespace = "GraphFixture",
            ClassName = "FixtureClient",
            FromCli = true,
            GenerateModels = true,
            GenerateMethods = true,
            GenerateJsonSerializerContextTypes = true,
            JsonSerializerContext = "GraphFixture.SourceGenerationContext",
            GroupByTags = true,
        };
        return AutoSDK.Generation.Data.Prepare(((Spec, settings), settings));
    }

    [TestMethod]
    public void Settings_PreserveSharedMetadataThroughTheCSharpBridge()
    {
        var settings = Settings.Default with { UseSharedJsonMetadata = true };
        CSharpSettings.FromSettings(settings).ToSettings().UseSharedJsonMetadata.Should().BeTrue();
    }

    [TestMethod]
    public void Plan_SeparatesOperationsWithinTheSameTag()
    {
        var data = Prepare();
        var plan = SerializerContextPlan.Create(data);
        var first = data.Methods.First(static method => method.NotAsyncMethodName == "First");
        var contexts = plan.OperationContexts[first.Id];
        var registered = plan.Groups.Where(group => contexts.Contains(group.Name))
            .SelectMany(static group => group.Types)
            .Select(static type => type.CSharpTypeWithoutNullability).ToArray();

        registered.Should().Contain("global::GraphFixture.FirstRequest");
        registered.Should().Contain("global::GraphFixture.Shared");
        registered.Should().NotContain("global::GraphFixture.SecondResponse");
        plan.ModelContexts["global::GraphFixture.Shared"].Should()
            .NotBe(plan.ModelContexts["global::GraphFixture.SecondResponse"]);
    }

    [TestMethod]
    public void Plan_SharedModelHelpersDoNotReconnectToUnrelatedRequests()
    {
        var plan = SerializerContextPlan.Create(Prepare());
        var shared = plan.Groups.Single(group => group.Name ==
            plan.ModelContexts["global::GraphFixture.Shared"]);
        shared.Types.Select(static type => type.CSharpTypeWithoutNullability)
            .Should().NotContain("global::GraphFixture.FirstRequest")
            .And.NotContain("global::GraphFixture.SecondResponse");
    }

    [TestMethod]
    public void Plan_PreservesNullableValueTypesWhenMergingGraphNodes()
    {
        var data = Prepare();
        var plan = SerializerContextPlan.Create(data);
        var shared = plan.Groups.Single(group => group.Name ==
            plan.ModelContexts["global::GraphFixture.Shared"]);
        shared.Types.Should().Contain(static type =>
            type.IsValueType &&
            type.CSharpTypeWithoutNullability == "global::System.DateTime" &&
            type.CSharpTypeWithNullability == "global::System.DateTime?");
    }

    [TestMethod]
    public void Plan_UnreferencedModelsKeepIndependentMetadataIslands()
    {
        var plan = SerializerContextPlan.Create(Prepare());
        plan.ModelContexts["global::GraphFixture.UnusedA"].Should()
            .NotBe(plan.ModelContexts["global::GraphFixture.UnusedB"]);
        var unused = plan.Groups.Single(group => group.Name ==
            plan.ModelContexts["global::GraphFixture.UnusedA"]);
        unused.Types.Select(static type => type.CSharpTypeWithoutNullability)
            .Should().NotContain("global::GraphFixture.UnusedB");
    }

    [TestMethod]
    public void Plan_RegistersPrimitiveUnionOnlyWhereItIsReachable()
    {
        var plan = SerializerContextPlan.Create(Prepare());
        var shared = plan.Groups.Single(group => group.Name ==
            plan.ModelContexts["global::GraphFixture.Shared"]);
        shared.Converters.Should().NotContain(static converter => converter.Contains("OneOfJsonConverter<"),
            because: "registered types are " + string.Join(", ", shared.Types.Select(static type => type.CSharpTypeWithoutNullability)));
        plan.Groups.SelectMany(static group => group.Converters)
            .Should().Contain(static converter => converter.Contains("OneOfJsonConverter<"));
    }
}
