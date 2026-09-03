using System.Collections.Immutable;
using AutoSDK.Models;
using AutoSDK.Packaging;

namespace AutoSDK.UnitTests;

/// <summary>
/// The safety rules that turn tag reachability into a package a model may actually ship in.
/// </summary>
/// <remarks>
/// Both cases here were found by generating <c>specs/github.yaml</c>, not by the two-tag fixture:
/// a real specification has type names that prefix one another and unions whose converters cannot
/// move.
/// </remarks>
[TestClass]
public class ModelOwnershipResolverTests
{
    [TestMethod]
    public void ResolveTypeOwner_MatchesWholeTypeNames_NotPrefixes()
    {
        var owners = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["global::GitHub.Topic"] = "repos",
            ["global::GitHub.TopicSearchResultItem"] = "search",
        };

        // Substring matching put IList<TopicSearchResultItem> in the repos package, which cannot
        // see the type, because "global::GitHub.Topic" is a prefix of it.
        ModelOwnershipResolver
            .ResolveTypeOwner("global::System.Collections.Generic.IList<global::GitHub.TopicSearchResultItem>", owners)
            .Should().Be("search");

        ModelOwnershipResolver
            .ResolveTypeOwner("global::System.Collections.Generic.IList<global::GitHub.Topic>", owners)
            .Should().Be("repos");
    }

    [TestMethod]
    public void ResolveTypeOwner_LeavesCompositesNamingTwoTagsInCore()
    {
        var owners = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["global::GitHub.Left"] = "repos",
            ["global::GitHub.Right"] = "search",
        };

        ModelOwnershipResolver
            .ResolveTypeOwner("global::GitHub.OneOf<global::GitHub.Left, global::GitHub.Right>", owners)
            .Should().BeNull();
    }

    [TestMethod]
    public void ResolveTypeOwner_ReturnsNullForUnownedTypes()
    {
        var owners = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["global::GitHub.Topic"] = "repos",
        };

        ModelOwnershipResolver.ResolveTypeOwner("string", owners).Should().BeNull();
        ModelOwnershipResolver.ResolveTypeOwner(string.Empty, owners).Should().BeNull();
    }

    [TestMethod]
    public void Resolve_KeepsEveryTypeAConverterNamesInOnePackage()
    {
        // The generated converter for an anonymous union is a generic instantiation, so whichever
        // package registers it has to see every argument. Splitting the arguments across packages
        // produced a context naming types that were not there.
        const string spec = """
openapi: 3.0.3
info:
  title: Catalogue
  version: 1.0.0
paths:
  /albums:
    post:
      operationId: createAlbum
      tags: [albums]
      requestBody:
        content:
          application/json:
            schema:
              oneOf:
                - type: object
                  properties:
                    byName:
                      type: string
                - type: object
                  properties:
                    byId:
                      type: integer
      responses:
        '200':
          description: OK
  /artists:
    get:
      operationId: listArtists
      tags: [artists]
      responses:
        '200':
          description: OK
""";

        var settings = Settings.Default with
        {
            Namespace = "Catalogue",
            ClassName = "CatalogueClient",
            GenerateModels = true,
            SplitByTags = true,
            BasePackageId = "tryAGI.Catalogue",
        };
        var data = AutoSDK.Generation.Data.Prepare(((spec, settings), GlobalSettings: settings));

        var owners = ModelOwnershipResolver.Resolve(data);

        foreach (var converter in data.Converters.Converters)
        {
            var mentioned = owners
                .Where(pair => converter.Contains(pair.Key, StringComparison.Ordinal))
                .Select(static pair => pair.Value)
                .Distinct(StringComparer.Ordinal)
                .ToArray();

            mentioned.Should().HaveCountLessThanOrEqualTo(
                1,
                because: $"'{converter}' has to be registered by a package that can see all of it, " +
                    "so its arguments cannot be split across tag packages");
        }
    }
}
