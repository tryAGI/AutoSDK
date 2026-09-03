using AutoSDK.Models;
using AutoSDK.Packaging;

namespace AutoSDK.UnitTests;

/// <summary>
/// Which tags reach which generated type — the input split-by-tags uses to decide whether a model
/// belongs to a tag package or to Core.
/// </summary>
[TestClass]
public class TagOwnershipAnalyzerTests
{
    private const string Spec = """
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
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Status'
  /albums:
    get:
      operationId: listAlbums
      tags: [albums]
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/AlbumPage'
  /albums/drafts:
    post:
      operationId: createDraft
      tags: [albums]
      requestBody:
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/AlbumDraft'
      responses:
        '200':
          description: OK
  /albums/audio:
    get:
      operationId: getAlbumAudio
      tags: [albums]
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/AudioMedia'
  /artists:
    get:
      operationId: listArtists
      tags: [artists]
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/AlbumPage'
  /artists/media:
    get:
      operationId: getArtistMedia
      tags: [artists]
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Media'
components:
  schemas:
    Status:
      type: object
      properties:
        healthy:
          type: boolean
    Album:
      type: object
      properties:
        id:
          type: string
    AlbumDraft:
      type: object
      properties:
        name:
          type: string
    AlbumPage:
      type: object
      properties:
        items:
          type: array
          items:
            $ref: '#/components/schemas/Album'
    Media:
      type: object
      required: [kind]
      properties:
        kind:
          type: string
      discriminator:
        propertyName: kind
        mapping:
          audio: '#/components/schemas/AudioMedia'
          video: '#/components/schemas/VideoMedia'
    AudioMedia:
      allOf:
        - $ref: '#/components/schemas/Media'
        - type: object
          properties:
            bitrate:
              type: integer
    VideoMedia:
      allOf:
        - $ref: '#/components/schemas/Media'
        - type: object
          properties:
            width:
              type: integer
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
    public void Analyze_AssignsEachTypeTheTagsThatReachIt()
    {
        var ownership = Analyze();

        // Reached through one tag's request body only.
        TagsFor(ownership, "global::Catalogue.AlbumDraft").Should().Equal("albums");

        // Reached by both tags: the page directly, the item transitively through the array.
        TagsFor(ownership, "global::Catalogue.AlbumPage").Should().Equal("albums", "artists");
        TagsFor(ownership, "global::Catalogue.Album").Should().Equal("albums", "artists");
    }

    [TestMethod]
    public void Analyze_LeavesTypesReachableOnlyFromUntaggedOperationsUnowned()
    {
        var ownership = Analyze();

        // Absent means "no tag claims it", which callers read as shared. Status is returned only
        // by the untagged operation, whose partials live in the base package.
        ownership.ContainsKey("global::Catalogue.Status").Should().BeFalse();
    }

    [TestMethod]
    public void Analyze_KeepsAPolymorphicFamilyTogetherEvenWhenOneSubtypeIsReachedByMoreTags()
    {
        var ownership = Analyze();

        // Only AudioMedia is returned by an albums operation; the base and the sibling are reached
        // through artists alone. Splitting on raw reachability would put AudioMedia in Core and its
        // base in the artists package, and the base names every subtype — an impossible reference.
        TagsFor(ownership, "global::Catalogue.AudioMedia").Should().Equal("albums", "artists");
        TagsFor(ownership, "global::Catalogue.Media").Should().Equal("albums", "artists");
        TagsFor(ownership, "global::Catalogue.VideoMedia").Should().Equal("albums", "artists");
    }

    private static IReadOnlyList<string> TagsFor(
        IReadOnlyDictionary<string, System.Collections.Immutable.ImmutableArray<string>> ownership,
        string type)
    {
        ownership.ContainsKey(type).Should().BeTrue(
            because: $"'{type}' should be reachable; known types: {string.Join(", ", ownership.Keys)}");

        return ownership[type];
    }

    private static IReadOnlyDictionary<string, System.Collections.Immutable.ImmutableArray<string>> Analyze()
    {
        var data = AutoSDK.Generation.Data.Prepare(((Spec, DefaultSettings), GlobalSettings: DefaultSettings));

        return TagOwnershipAnalyzer.Analyze(data.FilteredSchemas);
    }
}
