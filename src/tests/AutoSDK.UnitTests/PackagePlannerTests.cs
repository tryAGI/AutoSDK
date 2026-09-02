using AutoSDK.Models;
using AutoSDK.Packaging;

namespace AutoSDK.UnitTests;

/// <summary>
/// Determinism and routing rules for split-by-tags package planning.
/// </summary>
/// <remarks>
/// These cover the decisions the planner makes on its own. Whether the resulting family actually
/// compiles as separate assemblies is proven by the cross-assembly build test in
/// <c>AutoSDK.IntegrationTests.Cli</c>, not here.
/// </remarks>
[TestClass]
public class PackagePlannerTests
{
    private const string TwoTagSpec = """
openapi: 3.0.3
info:
  title: Catalogue
  version: 1.0.0
paths:
  /status:
    get:
      operationId: getStatus
      responses:
        '200':
          description: OK
  /albums:
    get:
      operationId: listAlbums
      tags:
        - albums
      responses:
        '200':
          description: OK
  /artists:
    get:
      operationId: listArtists
      tags:
        - artists
      responses:
        '200':
          description: OK
""";

    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "Catalogue",
        ClassName = "CatalogueClient",
        GenerateModels = true,
        SplitByTags = true,
        BasePackageId = "tryAGI.Catalogue",
    };

    [TestMethod]
    public void TryCreate_TwoTags_ProducesCoreTagPackagesAndFacadeInStableOrder()
    {
        var plan = CreatePlan(TwoTagSpec);

        plan.BasePackageId.Should().Be("tryAGI.Catalogue");
        plan.Core.PackageId.Should().Be("tryAGI.Catalogue.Core");
        plan.Facade.PackageId.Should().Be("tryAGI.Catalogue");

        plan.Packages.Select(x => x.PackageId).Should().Equal(
            "tryAGI.Catalogue.Core",
            "tryAGI.Catalogue.Albums",
            "tryAGI.Catalogue.Artists",
            "tryAGI.Catalogue");
        plan.Packages.Select(x => x.Kind).Should().Equal(
            PackageKind.Core,
            PackageKind.Tag,
            PackageKind.Tag,
            PackageKind.Facade);
    }

    [TestMethod]
    public void TryCreate_TagPackage_ReportsItsTagsAndClientClasses()
    {
        var plan = CreatePlan(TwoTagSpec);

        var albums = plan.Packages.Single(x => x.PackageId == "tryAGI.Catalogue.Albums");
        albums.Tags.Should().Equal("albums");
        albums.ClientClassNames.Should().Equal("AlbumsClient");
        albums.DirectoryName.Should().Be("tryAGI.Catalogue.Albums");
    }

    [TestMethod]
    public void ResolvePackageId_TagClientAndItsOperations_GoToThatTagPackage()
    {
        var plan = CreatePlan(TwoTagSpec);

        plan.ResolvePackageId("Catalogue.AlbumsClient.g.cs").Should().Be("tryAGI.Catalogue.Albums");
        plan.ResolvePackageId("Catalogue.IAlbumsClient.g.cs").Should().Be("tryAGI.Catalogue.Albums");
        plan.ResolvePackageId("Catalogue.AlbumsClient.ListAlbums.g.cs").Should().Be("tryAGI.Catalogue.Albums");
        plan.ResolvePackageId("Catalogue.IAlbumsClient.ListAlbums.g.cs").Should().Be("tryAGI.Catalogue.Albums");
    }

    [TestMethod]
    public void ResolvePackageId_RootClientPartials_GoToTheFacade()
    {
        var plan = CreatePlan(TwoTagSpec);

        // C# partial types cannot span assemblies, so everything that is a partial of the root
        // client class has to live together in the base package.
        plan.ResolvePackageId("Catalogue.CatalogueClient.g.cs").Should().Be("tryAGI.Catalogue");
        plan.ResolvePackageId("Catalogue.ICatalogueClient.g.cs").Should().Be("tryAGI.Catalogue");
        plan.ResolvePackageId("Catalogue.CatalogueClient.Authorizations.Bearer.g.cs").Should().Be("tryAGI.Catalogue");
        plan.ResolvePackageId("Catalogue.ICatalogueClient.Authorizations.Bearer.g.cs").Should().Be("tryAGI.Catalogue");
        plan.ResolvePackageId("Catalogue.CatalogueClient.Constructors.Bearer.g.cs").Should().Be("tryAGI.Catalogue");
        plan.ResolvePackageId("Catalogue.CatalogueClient.DependencyInjection.g.cs").Should().Be("tryAGI.Catalogue");
    }

    [TestMethod]
    public void ResolvePackageId_UntaggedOperation_GoesToTheFacade()
    {
        var plan = CreatePlan(TwoTagSpec);

        // An untagged operation is generated as a partial of the root client, so the facade is the
        // only package it can compile in.
        plan.ResolvePackageId("Catalogue.CatalogueClient.GetStatus.g.cs").Should().Be("tryAGI.Catalogue");
        plan.ResolvePackageId("Catalogue.ICatalogueClient.GetStatus.g.cs").Should().Be("tryAGI.Catalogue");
    }

    [TestMethod]
    public void ResolvePackageId_SharedModelsConvertersAndRuntime_GoToCore()
    {
        var plan = CreatePlan(TwoTagSpec);

        foreach (var fileName in new[]
        {
            "Catalogue.Models.Album.g.cs",
            "Catalogue.Models.Album.Json.g.cs",
            "Catalogue.JsonConverters.AlbumType.g.cs",
            "Catalogue.JsonSerializerContext.g.cs",
            "Catalogue.JsonSerializerContextTypes.g.cs",
            "Catalogue.OptionsSupport.g.cs",
            "Catalogue.Security.g.cs",
            "Catalogue.Polyfills.g.cs",
            "Catalogue.Exceptions.g.cs",
            "Catalogue.PathBuilder.g.cs",
            "Catalogue.AutoSDKHttpResponse.g.cs",
            "Catalogue.AutoSDKOAuth2.g.cs",
        })
        {
            plan.ResolvePackageId(fileName).Should().Be("tryAGI.Catalogue.Core", because: fileName);
        }
    }

    [TestMethod]
    public void TryCreate_PackageMapOverride_GroupsSeveralTagsIntoOnePackage()
    {
        var plan = CreatePlan(
            TwoTagSpec,
            tagPackageOverrides: new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["albums"] = "Catalog",
                ["artists"] = "Catalog",
            });

        plan.Packages.Select(x => x.PackageId).Should().Equal(
            "tryAGI.Catalogue.Core",
            "tryAGI.Catalogue.Catalog",
            "tryAGI.Catalogue");

        var grouped = plan.Packages.Single(x => x.Kind == PackageKind.Tag);
        grouped.Tags.Should().Equal("albums", "artists");
        grouped.ClientClassNames.Should().Equal("AlbumsClient", "ArtistsClient");

        plan.ResolvePackageId("Catalogue.AlbumsClient.g.cs").Should().Be("tryAGI.Catalogue.Catalog");
        plan.ResolvePackageId("Catalogue.ArtistsClient.g.cs").Should().Be("tryAGI.Catalogue.Catalog");
    }

    [TestMethod]
    public void TryCreate_TagNamedCore_DoesNotShadowTheSharedPackage()
    {
        var plan = CreatePlan(
            TwoTagSpec,
            tagPackageOverrides: new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["albums"] = "Core",
            });

        plan.Packages.Select(x => x.PackageId).Should().Contain("tryAGI.Catalogue.CoreApi");
        plan.Packages.Select(x => x.PackageId).Should().OnlyHaveUniqueItems();
        plan.ResolvePackageId("Catalogue.AlbumsClient.g.cs").Should().Be("tryAGI.Catalogue.CoreApi");
    }

    [TestMethod]
    public void TryCreate_UnusablePackageMapSuffix_FallsBackToTheTagName()
    {
        var plan = CreatePlan(
            TwoTagSpec,
            tagPackageOverrides: new Dictionary<string, string>(StringComparer.Ordinal)
            {
                // Nothing survives sanitization, so the deterministic tag-derived name is used.
                ["albums"] = "  ///  ",
            });

        plan.ResolvePackageId("Catalogue.AlbumsClient.g.cs").Should().Be("tryAGI.Catalogue.Albums");
    }

    [TestMethod]
    public void TryCreate_WithoutBasePackageId_FallsBackToTheNamespace()
    {
        var data = PrepareData(TwoTagSpec, DefaultSettings with { BasePackageId = string.Empty });

        PackagePlanner.TryCreate(data, tagPackageOverrides: null, out var plan, out _).Should().BeTrue();

        plan!.Value.BasePackageId.Should().Be("Catalogue");
        plan.Value.Core.PackageId.Should().Be("Catalogue.Core");
    }

    [TestMethod]
    public void TryCreate_IsDeterministicAcrossRuns()
    {
        var first = CreatePlan(TwoTagSpec);
        var second = CreatePlan(TwoTagSpec);

        second.Packages.Select(x => x.PackageId).Should().Equal(first.Packages.Select(x => x.PackageId));
        second.FileToPackageId.Should().BeEquivalentTo(first.FileToPackageId);
    }

    [TestMethod]
    public void TryCreate_SingleTagSpec_IsRejectedWithAnActionableMessage()
    {
        const string singleTagSpec = """
openapi: 3.0.3
info:
  title: Catalogue
  version: 1.0.0
paths:
  /albums:
    get:
      operationId: listAlbums
      tags:
        - albums
      responses:
        '200':
          description: OK
""";
        var data = PrepareData(singleTagSpec, DefaultSettings);

        PackagePlanner.TryCreate(data, tagPackageOverrides: null, out var plan, out var error)
            .Should().BeFalse();

        plan.Should().BeNull();
        error.Should().Contain("at least two OpenAPI tags");
    }

    [TestMethod]
    public void TryCreate_WithoutClientClassName_IsRejected()
    {
        var data = PrepareData(TwoTagSpec, DefaultSettings with { ClassName = string.Empty });

        PackagePlanner.TryCreate(data, tagPackageOverrides: null, out _, out var error)
            .Should().BeFalse();

        // Without it the planner cannot recognise the root client's own files, and a prefix of
        // "Catalogue." would swallow every generated file into the facade.
        error.Should().Contain("--clientClassName");
    }

    private static PackagePlan CreatePlan(
        string yaml,
        IReadOnlyDictionary<string, string>? tagPackageOverrides = null)
    {
        var data = PrepareData(yaml, DefaultSettings);

        PackagePlanner.TryCreate(data, tagPackageOverrides, out var plan, out var error)
            .Should().BeTrue(because: error);

        return plan!.Value;
    }

    private static AutoSDK.Models.Data PrepareData(string yaml, Settings settings)
    {
        return AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
    }
}
