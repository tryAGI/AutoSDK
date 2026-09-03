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
    public void Resolve_KeepsUnionVariantsInCore()
    {
        // The generated converter for an anonymous union is a generic instantiation registered in
        // Core's options, so Core has to be able to see every variant. Letting the albums tag take
        // them produced a Core file naming types that were no longer there.
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
            foreach (var owned in owners.Keys)
            {
                converter.Should().NotContain(
                    owned,
                    because: $"'{owned}' is registered by a converter Core keeps, so it cannot move out of Core");
            }
        }
    }
}
