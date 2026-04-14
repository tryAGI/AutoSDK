using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class PaginationGenerationTests
{
    private static CSharpSettings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net8.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateSdk = true,
        GenerateModels = true,
        GenerateConstructors = true,
    };

    [TestMethod]
    public void GenerateMethod_WithSpeakeasyCursorPagination_EmitsPaginationHelpersAndSupport()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: SpeakeasyPagination
  version: 1.0.0
paths:
  /widgets:
    get:
      operationId: listWidgets
      parameters:
        - in: query
          name: cursor
          schema:
            type: string
        - in: query
          name: limit
          schema:
            type: integer
      x-speakeasy-pagination:
        type: cursor
        inputs:
          - name: cursor
            in: query
            type: cursor
          - name: limit
            in: query
            type: limit
        outputs:
          results: $.data
          nextCursor: $.next_cursor
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  data:
                    type: array
                    items:
                      type: object
                      properties:
                        id:
                          type: string
                  next_cursor:
                    type: string
""";

        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;
        var supportSource = Sources.PaginationSupport(settings).Text;
        var fileNames = CSharpPipeline.GenerateFiles(data).Select(x => x.Name).ToArray();

        method.HasPagination.Should().BeTrue();
        method.GenerateResponseWrapper.Should().BeTrue();
        method.Pagination!.Value.Scheme.Should().Be(PaginationScheme.Cursor);

        methodSource.Should().Contain("ListWidgetsAsPageAsync(");
        methodSource.Should().Contain("ListWidgetsAsItemsAsync(");
        methodSource.Should().Contain("ListWidgetsAsResponseAsync(");
        methodSource.Should().Contain("AutoSDKPaginationSupport.ExtractItems<");
        supportSource.Should().Contain("public sealed class AutoSDKPage<TItem, TResponse>");
        fileNames.Should().Contain("G.AutoSDKPagination.g.cs");
    }

    [TestMethod]
    public void GenerateMethod_WithStainlessRequestBodyCursorPagination_ClonesRequestForNextPage()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: StainlessBodyCursor
  version: 1.0.0
paths:
  /search:
    post:
      operationId: searchThings
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              properties:
                query:
                  type: string
                cursor:
                  type: string
                  x-stainless-pagination-property:
                    purpose: next_cursor_param
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  items:
                    type: array
                    x-stainless-pagination-property:
                      purpose: items
                    items:
                      type: object
                      properties:
                        id:
                          type: string
                  next_cursor:
                    type: string
                    x-stainless-pagination-property:
                      purpose: next_cursor_field
""";

        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;

        method.HasPagination.Should().BeTrue();
        method.Pagination!.Value.Scheme.Should().Be(PaginationScheme.Cursor);
        method.Pagination!.Value.NextCursorBinding.Target.Should().Be(PaginationRequestBindingTarget.RequestBodyProperty);

        methodSource.Should().Contain("var __nextRequest = new");
        methodSource.Should().Contain("request: __nextRequest");
        methodSource.Should().Contain("CoerceValue<string?>(__nextCursor!)");
    }

    [TestMethod]
    public void GenerateMethod_WithStainlessTopLevelArrayAndHeaderCursor_UsesHeaderBinding()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: StainlessHeaderCursor
  version: 1.0.0
paths:
  /events:
    get:
      operationId: listEvents
      parameters:
        - in: query
          name: after
          schema:
            type: string
            x-stainless-pagination-property:
              purpose: next_cursor_param
      responses:
        '200':
          description: OK
          headers:
            X-Next-Cursor:
              schema:
                type: string
          content:
            application/json:
              schema:
                type: array
                x-stainless-pagination-property:
                  is_top_level_array: true
                items:
                  type: object
                  x-stainless-pagination-property:
                    purpose: next_cursor_field
                    from_header: X-Next-Cursor
                  properties:
                    id:
                      type: string
""";

        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;

        method.HasPagination.Should().BeTrue();
        method.Pagination!.Value.ItemsAreTopLevelArray.Should().BeTrue();
        method.Pagination!.Value.NextCursorValue.Source.Should().Be(PaginationValueSource.Header);

        methodSource.Should().Contain("GetHeaderString(__response, \"X-Next-Cursor\")");
        methodSource.Should().Contain("isTopLevelArray: true");
    }

    [TestMethod]
    public void GenerateMethod_WithUrlPagination_UsesAbsoluteRequestUriOverride()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: UrlPagination
  version: 1.0.0
paths:
  /records:
    get:
      operationId: listRecords
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  data:
                    type: array
                    x-stainless-pagination-property:
                      purpose: items
                    items:
                      type: object
                      properties:
                        id:
                          type: string
                  next_url:
                    type: string
                    format: uri
                    x-stainless-pagination-property:
                      purpose: cursor_url_field
""";

        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;

        method.HasPagination.Should().BeTrue();
        method.Pagination!.Value.Scheme.Should().Be(PaginationScheme.Url);

        methodSource.Should().Contain("AbsoluteRequestUriOverride = __nextPageUri");
        methodSource.Should().Contain("requestOptions?.AbsoluteRequestUriOverride");
    }

    [TestMethod]
    public void GenerateMethod_WithIncompletePaginationMetadata_SkipsPaginationHelpers()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: InvalidPagination
  version: 1.0.0
paths:
  /widgets:
    get:
      operationId: listWidgets
      parameters:
        - in: query
          name: cursor
          schema:
            type: string
      x-speakeasy-pagination:
        type: cursor
        inputs:
          - name: cursor
            in: query
            type: cursor
        outputs:
          nextCursor: $.next_cursor
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  next_cursor:
                    type: string
""";

        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;
        var fileNames = CSharpPipeline.GenerateFiles(data).Select(x => x.Name).ToArray();

        method.HasPagination.Should().BeFalse();
        methodSource.Should().NotContain("AsPageAsync(");
        methodSource.Should().NotContain("AsItemsAsync(");
        fileNames.Should().NotContain("G.AutoSDKPagination.g.cs");
    }
}
