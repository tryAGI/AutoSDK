using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class TreeShakeableJsonSerializerContextTests
{
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
}
