using System.Collections.Immutable;
using AutoSDK.Extensions;
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
        timestamps:
          type: array
          items:
            anyOf:
              - type: string
                format: date
              - type: 'null'
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
    public void SharedMetadata_RegistersNullableScalarsInsideCollectionGraphs()
    {
        var data = Prepare();
        data = data with
        {
            Converters = data.Converters with
            {
                Settings = data.Converters.Settings with { UseSharedJsonMetadata = true },
            },
        };
        var files = CSharpPipeline.GenerateFiles(data);
        files.Where(static file => file.Name.EndsWith(".JsonSerializerContext.g.cs", StringComparison.Ordinal))
            .Should().Contain(static file =>
                file.Text.Contains("if (type == typeof(global::System.DateTime?))", StringComparison.Ordinal));
        files.Single(static file => file.Name.EndsWith(".autosdk-json-metadata", StringComparison.Ordinal))
            .Text.Should().Contain("typeof(global::System.DateTime?)");
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
    public void SharedPlan_NestedHelpersAndOrphansFollowOnlyOutgoingDependencies()
    {
        var data = Prepare();
        data = data with { Converters = data.Converters with
            { Settings = data.Converters.Settings with { UseSharedJsonMetadata = true } } };
        var plan = SerializerContextPlan.Create(data);
        var sharedContext = plan.ModelContexts["global::GraphFixture.Shared"];
        var shared = plan.Groups.Single(group => group.Name == sharedContext);
        shared.Types.Select(static type => type.CSharpTypeWithoutNullability)
            .Should().Equal("global::GraphFixture.Shared");
        var reachable = new HashSet<string>(StringComparer.Ordinal);
        var pending = new Stack<string>();
        pending.Push(sharedContext);
        while (pending.Count != 0)
        {
            var name = pending.Pop();
            if (!reachable.Add(name)) continue;
            foreach (var dependency in plan.Groups.Single(group => group.Name == name).Dependencies)
                pending.Push(dependency);
        }
        reachable.Should().NotContain(plan.ModelContexts["global::GraphFixture.FirstRequest"])
            .And.NotContain(plan.ModelContexts["global::GraphFixture.SecondResponse"])
            .And.NotContain(plan.ModelContexts["global::GraphFixture.UnusedA"]);
        plan.Groups.SelectMany(static group => group.Types)
            .Select(static type => type.CSharpTypeWithoutNullability).Should().OnlyHaveUniqueItems();
        plan.Groups.Should().Contain(group => group.Name == plan.ModelContexts["global::System.DateTime"] &&
            group.Types.Any(type => type.CSharpTypeWithNullability == "global::System.DateTime?"));
    }

    [TestMethod]
    public void SharedPlan_ComponentsKeepCyclesTogetherWithoutTheirParents()
    {
        var spec = Spec.Replace("    UnusedA:\n", """
    CycleA:
      type: object
      properties:
        child:
          $ref: '#/components/schemas/CycleB'
    CycleB:
      type: object
      properties:
        child:
          $ref: '#/components/schemas/CycleA'
    CycleParent:
      type: object
      properties:
        child:
          $ref: '#/components/schemas/CycleA'
    UnusedA:

""", StringComparison.Ordinal);
        var data = Prepare();
        var settings = data.Converters.Settings with { UseSharedJsonMetadata = true };
        data = AutoSDK.Generation.Data.Prepare(((spec, settings), settings));
        var plan = SerializerContextPlan.Create(data);
        plan.ModelContexts["global::GraphFixture.CycleA"].Should()
            .Be(plan.ModelContexts["global::GraphFixture.CycleB"])
            .And.NotBe(plan.ModelContexts["global::GraphFixture.CycleParent"]);
        var cycle = plan.Groups.Single(group => group.Name == plan.ModelContexts["global::GraphFixture.CycleA"]);
        cycle.Dependencies.Should().NotContain(plan.ModelContexts["global::GraphFixture.CycleParent"]);
    }

    [TestMethod]
    public void SharedPlan_EmittedModelsOmittedFromRegisteredTypesNeverFallBackToTheAggregate()
    {
        var data = Prepare();
        data = data with
        {
            Types = data.Types.Where(static type => type.CSharpTypeWithoutNullability != "global::GraphFixture.UnusedA")
                .ToImmutableArray().AsEquatableArray(),
            Converters = data.Converters with { Settings = data.Converters.Settings with { UseSharedJsonMetadata = true } },
        };
        var plan = SerializerContextPlan.Create(data);
        foreach (var model in data.Classes.Concat(data.Enums))
            plan.ModelContexts.Should().ContainKey(model.GlobalClassName);
        var files = CSharpPipeline.GenerateFiles(data);
        files.Single(static file => file.Name.EndsWith(".Models.UnusedA.Json.g.cs", StringComparison.Ordinal)).Text
            .Should().Contain(plan.ModelContexts["global::GraphFixture.UnusedA"])
            .And.NotContain("global::GraphFixture.SourceGenerationContext.Default");
        files.Single(static file => file.Name.EndsWith(".autosdk-json-metadata", StringComparison.Ordinal)).Text
            .Should().Contain("typeof(global::GraphFixture.UnusedA)");
    }

    [TestMethod]
    public void SharedPlan_EmitsOneManifestAndCoordinatedBuildOnlyVersionBinding()
    {
        var data = Prepare();
        data = data with { Converters = data.Converters with
            { Settings = data.Converters.Settings with { UseSharedJsonMetadata = true } } };
        var files = CSharpPipeline.GenerateFiles(data);
        var manifest = files.Single(static file => file.Name.EndsWith(".autosdk-json-metadata", StringComparison.Ordinal));
        manifest.Text.Should().StartWith("// AutoSDK.JsonMetadata manifest-format: 2\n");
        manifest.Text.Split("JsonSourceGenerationOptions", StringSplitOptions.None).Length.Should().Be(2);
        manifest.Text.Should().Contain("ManifestProtocol.Version2");
        var binding = files.Single(static file => file.Name == "AutoSDK.SharedJsonMetadata.props");
        binding.Text.Should().Contain("<AutoSDKJsonMetadataVersion>")
            .And.Contain("<AutoSDKJsonMetadataManifestVersion>2</AutoSDKJsonMetadataManifestVersion>");
        var shared = files.Single(file => file.Name.StartsWith(
            SerializerContextPlan.Create(data).ModelContexts["global::GraphFixture.Shared"] + ".", StringComparison.Ordinal));
        shared.Text.Should().Contain(".MetadataScope").And.NotContain("typeof(global::GraphFixture.FirstRequest)");
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
