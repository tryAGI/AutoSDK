using AutoSDK.Generation;
using AutoSDK.Models;
using System.Reflection;

namespace AutoSDK.UnitTests;

[TestClass]
public class PageableNextUrlTests
{
    private const string JsonApiSpec = """
openapi: 3.0.3
info:
  title: App Store Connect style pagination
  version: 1.0.0
servers:
  - url: https://api.example.test
paths:
  /v1/apps:
    get:
      operationId: listApps
      parameters:
        - name: filter[name]
          in: query
          schema:
            type: string
        - name: include
          in: query
          schema:
            type: string
        - name: limit
          in: query
          schema:
            type: integer
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/AppsPage'
components:
  schemas:
    AppsPage:
      type: object
      properties:
        data:
          type: array
          items:
            $ref: '#/components/schemas/App'
        links:
          $ref: '#/components/schemas/DocumentLinks'
    DocumentLinks:
      type: object
      properties:
        next:
          type: string
          format: uri
          nullable: true
    App:
      type: object
      properties:
        id:
          type: string
""";

    [TestMethod]
    public void JsonApiLinksNext_EmitsTypedCompanionAndPreservesFilters()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GeneratePageableHelpers = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((JsonApiSpec, (CSharpSettings)settings), (CSharpSettings)settings));
        var endpoint = data.Methods.Single();

        endpoint.PageableMetadata.Style.Should().Be(PageableStyle.NextUrl);
        endpoint.PageableMetadata.ItemsPropertyName.Should().Be("Data");
        endpoint.PageableMetadata.LinksPropertyName.Should().Be("Links");
        endpoint.PageableMetadata.NextCursorPropertyName.Should().Be("Next");

        var method = typeof(Sources).GetMethod("GenerateAutoPagingCompanion", BindingFlags.NonPublic | BindingFlags.Static)!;
        var companion = (string)method.Invoke(null, [endpoint, false])!;
        companion.Should().Contain("ListAppsAutoPagingAsync(");
        companion.Should().Contain("AutoSDKPager.NextUrlAsync<");
        companion.Should().Contain("__response.Links?.Next");
        companion.Should().Contain("AutoSDKPager.CreatePageRequestOptions(requestOptions, __nextUrl)");
        companion.Should().Contain("filterName: filterName");
        companion.Should().Contain("include: include");
        companion.Should().Contain("limit: limit");

        Sources.Method(endpoint).Text.Should().Contain("AutoSDKPager.ResolvePageUrl(");
    }

    [TestMethod]
    public void JsonApiLinksNext_WithAmbiguousItemOrLinkShape_OmitsCompanion()
    {
        var settings = Settings.Default with { GeneratePageableHelpers = true };
        foreach (var addition in new[]
                 {
                     """
        included:
          type: array
          items:
            type: object
""",
                     """
        next_url:
          type: string
""",
                 })
        {
            var yaml = JsonApiSpec.Replace("        links:\n", addition + "\n        links:\n", StringComparison.Ordinal);
            var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
            data.Methods.Single().HasPageableHelper.Should().BeFalse();
        }
    }

    [TestMethod]
    public void JsonApiLinksNext_ExplicitPropertyOverridesResolveAmbiguousShape()
    {
        var yaml = JsonApiSpec
            .Replace("      operationId: listApps\n", """
      operationId: listApps
      x-autosdk-pageable-items: data
      x-autosdk-pageable-next-url: links.next
""" + "\n", StringComparison.Ordinal)
            .Replace("        links:\n", """
        included:
          type: array
          items:
            type: object
        next_url:
          type: string
""" + "\n        links:\n", StringComparison.Ordinal);
        var settings = Settings.Default with { GeneratePageableHelpers = true };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));

        data.Methods.Single().PageableMetadata.Style.Should().Be(PageableStyle.NextUrl);
        data.Methods.Single().PageableMetadata.ItemsPropertyName.Should().Be("Data");
        data.Methods.Single().PageableMetadata.LinksPropertyName.Should().Be("Links");

        var invalid = yaml.Replace("x-autosdk-pageable-next-url: links.next", "x-autosdk-pageable-next-url: links.missing", StringComparison.Ordinal);
        var invalidData = AutoSDK.Generation.Data.Prepare(((invalid, (CSharpSettings)settings), (CSharpSettings)settings));
        invalidData.Methods.Single().HasPageableHelper.Should().BeFalse();
    }

    [TestMethod]
    public void NextUrlAsync_EmittedWhenPageableHelpersEnabled()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GeneratePageableHelpers = true,
        };

        var source = Sources.GeneratePageableHelpers(settings);

        source.Should().Contain("public static async global::System.Collections.Generic.IAsyncEnumerable<TItem> NextUrlAsync<TPage, TItem>(");
        source.Should().Contain("Refusing to follow next-page URL");
        source.Should().Contain("EnsureSameOrigin(url!, baseAddress);");
        source.Should().Contain("public static void EnsureSameOrigin(string nextUrl, global::System.Uri? baseAddress)");
    }

    [TestMethod]
    public void NextUrlAsync_OmittedWhenPageableHelpersDisabled()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GeneratePageableHelpers = false,
        };

        var file = Sources.PageableHelpers(settings);

        // When pageable helpers are off, the file is emitted empty.
        file.Text.Should().BeEmpty();
    }
}
