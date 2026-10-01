using System.Collections.Immutable;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Packaging;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class TreeShakeableJsonSerializerContextTests
{
    [TestMethod]
    public void AggregateFallbackContext_KeepsPublicTagContextWithoutDuplicateRegistrations()
    {
        var settings = Settings.Default with
        {
            Namespace = "Catalogue",
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            JsonSerializerContext = "Catalogue.AlbumsSourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            FromCli = true,
        };
        var client = new Client(
            Id: "Albums",
            ClassName: "AlbumsClient",
            FileNameWithoutExtension: "Catalogue.Albums",
            InterfaceFileNameWithoutExtension: "IAlbums",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);

        var generated = Sources.GenerateJsonSerializerContext(
            client,
            ImmutableArray<TypeData>.Empty.AsEquatableArray(),
            new Sources.JsonSerializerContextGenerationState(),
            fallbackContextNames: ["global::Catalogue.SourceGenerationContext"]);

        generated.Should().Contain("public sealed partial class AlbumsSourceGenerationContext");
        generated.Should().Contain("global::Catalogue.SourceGenerationContext.TypeInfoResolver");
        generated.Should().Contain("global::Catalogue.SourceGenerationContext.AddConverters(options);");
        generated.Should().NotContain("[global::System.Text.Json.Serialization.JsonSerializable(");
    }

    private const string Spec = """
openapi: 3.0.3
info:
  title: Tree-shakeable contexts
  version: 1.0.0
paths:
  /albums:
    post:
      operationId: createAlbum
      tags: [albums]
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/Album'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedResult'
  /artists:
    post:
      operationId: createArtist
      tags: [artists]
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/Artist'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedResult'
  /genres:
    post:
      operationId: createGenre
      tags: [genres]
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/Genre'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedResult'
  /labels:
    post:
      operationId: createLabel
      tags: [labels]
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/Label'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedResult'
components:
  schemas:
    Album:
      type: object
      properties:
        title:
          type: string
        format:
          $ref: '#/components/schemas/AlbumFormat'
    AlbumFormat:
      type: string
      enum: [vinyl, digital]
    Artist:
      type: object
      properties:
        name:
          type: string
        kind:
          $ref: '#/components/schemas/ArtistKind'
    ArtistKind:
      type: string
      enum: [solo, group]
    Genre:
      type: object
      properties:
        detail:
          $ref: '#/components/schemas/GenreDetail'
    GenreDetail:
      type: object
      properties:
        name:
          type: string
        next:
          $ref: '#/components/schemas/GenreDetail2'
    GenreDetail2:
      type: object
      properties:
        next:
          $ref: '#/components/schemas/GenreDetail3'
    GenreDetail3:
      type: object
      properties:
        name:
          type: string
    Label:
      type: object
      properties:
        detail:
          $ref: '#/components/schemas/LabelDetail'
    LabelDetail:
      type: object
      properties:
        name:
          type: string
        next:
          $ref: '#/components/schemas/LabelDetail2'
    LabelDetail2:
      type: object
      properties:
        next:
          $ref: '#/components/schemas/LabelDetail3'
    LabelDetail3:
      type: object
      properties:
        name:
          type: string
    SharedResult:
      type: object
      properties:
        id:
          type: string
""";

    [TestMethod]
    public void GenerateFiles_GroupedCli_EmitsIndependentReachableContextsForLeafClients()
    {
        var settings = Settings.Default with
        {
            Namespace = "Catalogue",
            ClassName = "CatalogueClient",
            GenerateModels = true,
            GenerateMethods = true,
            GenerateConstructors = true,
            GenerateSdk = true,
            GenerateJsonSerializerContextTypes = true,
            JsonSerializerContext = "Catalogue.SourceGenerationContext",
            GroupByTags = true,
            FromCli = true,
        };

        var data = CSharpPipeline.PrepareAndEnrich(((Spec, settings), settings));
        var files = CSharpPipeline.GenerateFiles(data).ToDictionary(static x => x.Name, StringComparer.Ordinal);

        files.Should().ContainKey("Catalogue.JsonSerializerContext.g.cs");
        files.Should().ContainKey("Catalogue.Albums.JsonSerializerContext.g.cs");
        files.Should().ContainKey("Catalogue.Artists.JsonSerializerContext.g.cs");

        files["Catalogue.AlbumsClient.g.cs"].Text
            .Should().Contain("global::Catalogue.AlbumsSourceGenerationContext.Default")
            .And.NotContain("global::Catalogue.SourceGenerationContext.Default");
        files["Catalogue.ArtistsClient.g.cs"].Text
            .Should().Contain("global::Catalogue.ArtistsSourceGenerationContext.Default")
            .And.NotContain("global::Catalogue.SourceGenerationContext.Default");
        files["Catalogue.CatalogueClient.g.cs"].Text
            .Should().Contain("global::Catalogue.SourceGenerationContext.Default")
            .And.Contain("JsonSerializerContextProvider = JsonSerializerContextProvider");

        var albumsContext = files["Catalogue.Albums.JsonSerializerContext.g.cs"].Text;
        albumsContext.Should().Contain("global::Catalogue.Album");
        albumsContext.Should().Contain("global::Catalogue.SharedResult");
        albumsContext.Should().Contain("global::Catalogue.JsonConverters.AlbumFormatJsonConverter");
        albumsContext.Should().NotContain("global::Catalogue.Artist");
        albumsContext.Should().NotContain("global::Catalogue.JsonConverters.ArtistKindJsonConverter");
        albumsContext.Should().NotContain("global::Catalogue.JsonSerializerContextTypes");

        var artistsContext = files["Catalogue.Artists.JsonSerializerContext.g.cs"].Text;
        artistsContext.Should().Contain("global::Catalogue.Artist");
        artistsContext.Should().Contain("global::Catalogue.SharedResult");
        artistsContext.Should().NotContain("global::Catalogue.Album");
        artistsContext.Should().NotContain("global::Catalogue.JsonSerializerContextTypes");
    }

    [TestMethod]
    public void MonolithicPartition_KeepsThePublicContextAndRegistersOwnedModelsOnce()
    {
        var settings = Settings.Default with
        {
            Namespace = "Catalogue",
            ClassName = "CatalogueClient",
            GenerateModels = true,
            GenerateMethods = true,
            GenerateConstructors = true,
            GenerateSdk = true,
            GenerateJsonSerializerContextTypes = true,
            JsonSerializerContext = "Catalogue.SourceGenerationContext",
            GroupByTags = true,
            FromCli = true,
        };
        var data = CSharpPipeline.PrepareAndEnrich(((Spec, settings), settings));
        var owners = ModelOwnershipResolver.Resolve(data);
        owners.Should().NotBeEmpty();

        var contexts = CSharpPipeline.CreateMonolithicPartitionJsonSerializerContexts(
                data,
                owners,
                CancellationToken.None)
            .ToDictionary(static file => file.Name, StringComparer.Ordinal);

        var root = contexts["Catalogue.JsonSerializerContext.g.cs"].Text;
        root.Should().Contain("public sealed partial class SourceGenerationContext")
            .And.Contain("global::Catalogue.PartitionCoreSourceGenerationContext.TypeInfoResolver")
            .And.Contain("global::Catalogue.AlbumsSourceGenerationContext.TypeInfoResolver")
            .And.Contain("global::Catalogue.ArtistsSourceGenerationContext.TypeInfoResolver")
            .And.NotContain("[global::System.Text.Json.Serialization.JsonSerializable(");

        var albums = contexts["Catalogue.Albums.JsonSerializerContext.g.cs"].Text;
        albums.Should().Contain("global::Catalogue.Album")
            .And.NotContain("global::Catalogue.Artist");
        var artists = contexts["Catalogue.Artists.JsonSerializerContext.g.cs"].Text;
        artists.Should().Contain("global::Catalogue.Artist")
            .And.NotContain("global::Catalogue.Album");
    }

    [TestMethod]
    public void GenerateFiles_GroupedCli_KeepsDenseLeafGraphsOnAggregateContext()
    {
        const string denseSpec = """
openapi: 3.0.3
info:
  title: Dense tag contexts
  version: 1.0.0
paths:
  /albums:
    get:
      operationId: getAlbums
      tags: [albums]
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedResult'
  /artists:
    get:
      operationId: getArtists
      tags: [artists]
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedResult'
components:
  schemas:
    SharedResult:
      type: object
      properties:
        id:
          type: string
""";
        var settings = Settings.Default with
        {
            Namespace = "Catalogue",
            ClassName = "CatalogueClient",
            GenerateModels = true,
            GenerateMethods = true,
            GenerateConstructors = true,
            GenerateSdk = true,
            GenerateJsonSerializerContextTypes = true,
            JsonSerializerContext = "Catalogue.SourceGenerationContext",
            GroupByTags = true,
            FromCli = true,
        };

        var data = CSharpPipeline.PrepareAndEnrich(((denseSpec, settings), settings));
        var files = CSharpPipeline.GenerateFiles(data).ToDictionary(static x => x.Name, StringComparer.Ordinal);

        files.Should().NotContainKey("Catalogue.Albums.JsonSerializerContext.g.cs");
        files.Should().NotContainKey("Catalogue.Artists.JsonSerializerContext.g.cs");
        files["Catalogue.AlbumsClient.g.cs"].Text
            .Should().Contain("global::Catalogue.SourceGenerationContext.Default");
        files["Catalogue.ArtistsClient.g.cs"].Text
            .Should().Contain("global::Catalogue.SourceGenerationContext.Default");
    }
}
