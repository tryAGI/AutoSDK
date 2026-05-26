using AutoSDK.Generation;
using AutoSDK.Models;
using System.Text.RegularExpressions;

namespace AutoSDK.UnitTests;

[TestClass]
public class PolymorphicArrayDetectionTests
{
    // Firecrawl-shaped scrape formats: bare-string markdown/html/links + typed json + typed highlights.
    // Uses single-value enum for the discriminator so the spec works on both OpenAPI 3.0 and 3.1
    // (3.0 doesn't recognize the `const` keyword; 3.1's `const` and single-value `enum` are equivalent).
    private const string FirecrawlShapedSpec = """
                                                openapi: 3.1.0
                                                info:
                                                  title: Polymorphic Demo
                                                  version: 1.0.0
                                                paths:
                                                  /scrape:
                                                    post:
                                                      operationId: scrape
                                                      requestBody:
                                                        required: true
                                                        content:
                                                          application/json:
                                                            schema:
                                                              $ref: '#/components/schemas/ScrapeRequest'
                                                      responses:
                                                        '200':
                                                          description: ok
                                                components:
                                                  schemas:
                                                    ScrapeRequest:
                                                      type: object
                                                      properties:
                                                        formats:
                                                          type: array
                                                          description: Output formats to render.
                                                          items:
                                                            oneOf:
                                                              - type: string
                                                                enum: [markdown, html, links]
                                                                description: Bare-string render formats.
                                                              - type: object
                                                                description: JSON-extract format with a schema and prompt.
                                                                properties:
                                                                  type:
                                                                    type: string
                                                                    enum: [json]
                                                                  prompt:
                                                                    type: string
                                                                    description: The extraction prompt.
                                                                  maxItems:
                                                                    type: integer
                                                              - type: object
                                                                properties:
                                                                  type:
                                                                    type: string
                                                                    enum: [highlights]
                                                                  query:
                                                                    type: string
                                                """;

    private const string RichPropertyTypesSpec = """
                                                 openapi: 3.1.0
                                                 info:
                                                   title: Polymorphic Demo
                                                   version: 1.0.0
                                                 paths:
                                                   /scrape:
                                                     post:
                                                       operationId: scrape
                                                       requestBody:
                                                         required: true
                                                         content:
                                                           application/json:
                                                             schema:
                                                               $ref: '#/components/schemas/ScrapeRequest'
                                                       responses:
                                                         '200':
                                                           description: ok
                                                 components:
                                                   schemas:
                                                     ExtractionSchema:
                                                       type: object
                                                       properties:
                                                         type:
                                                           type: string
                                                         enabled:
                                                           type: boolean
                                                     Rule:
                                                       type: object
                                                       properties:
                                                         field:
                                                           type: string
                                                     ScrapeRequest:
                                                       type: object
                                                       properties:
                                                         formats:
                                                           type: array
                                                           items:
                                                             oneOf:
                                                               - type: string
                                                                 enum: [markdown]
                                                               - type: object
                                                                 properties:
                                                                   type:
                                                                     type: string
                                                                     enum: [json]
                                                                   schema:
                                                                     $ref: '#/components/schemas/ExtractionSchema'
                                                                   mode:
                                                                     type: string
                                                                     enum: [strict, lenient]
                                                                   rules:
                                                                     type: array
                                                                     items:
                                                                       $ref: '#/components/schemas/Rule'
                                                                   settings:
                                                                     type: object
                                                                     properties:
                                                                       minScore:
                                                                         type: number
                                                                       includeHidden:
                                                                         type: boolean
                                                 """;

    private static Settings BuildSettings(bool flag) => Settings.Default with
    {
        Namespace = "Demo",
        ClassName = "Api",
        GenerateModels = true,
        GenerateMethods = true,
        GenerateSdk = true,
        TargetFramework = "net8.0",
        GeneratePolymorphicArrayHelpers = flag,
    };

    [TestMethod]
    public void Pipeline_WhenFlagOff_EmitsNoPolymorphicFormatFiles()
    {
        var settings = BuildSettings(flag: false);
        var data = AutoSDK.Generation.Data.Prepare(((FirecrawlShapedSpec, settings), GlobalSettings: settings));

        var files = Sources.PolymorphicArrayClasses(settings, data.Schemas).ToArray();

        files.Should().BeEmpty();
    }

    [TestMethod]
    public void Pipeline_WhenFlagOn_EmitsBaseAndVariantSubclasses()
    {
        var settings = BuildSettings(flag: true);
        var data = AutoSDK.Generation.Data.Prepare(((FirecrawlShapedSpec, settings), GlobalSettings: settings));

        var files = Sources.PolymorphicArrayClasses(settings, data.Schemas).ToArray();

        // One file emitted for the formats array.
        files.Length.Should().Be(1);
        var file = files[0];
        file.Name.Should().EndWith(".g.cs");
        file.Name.Should().Contain("ScrapeRequestFormatsItem");

        var text = file.Text;

        // Abstract base + JsonConverter attribute wired to AutoSDKPolymorphicFormatJsonConverter<TBase>.
        text.Should().Contain("public abstract partial class ScrapeRequestFormatsItem : global::Demo.AutoSDKPolymorphicFormat");
        text.Should().Contain("[global::System.Text.Json.Serialization.JsonConverter(typeof(global::Demo.AutoSDKPolymorphicFormatJsonConverter<global::Demo.ScrapeRequestFormatsItem>))]");

        // All three bare-string variants registered + emitted as IsBareString=true.
        foreach (var stringValue in new[] { "markdown", "html", "links" })
        {
            var className = char.ToUpperInvariant(stringValue[0]) + stringValue.Substring(1) + "Format";
            text.Should().Contain($"[global::Demo.AutoSDKPolymorphicFormatVariant(\"{stringValue}\", typeof(global::Demo.{className}))]");
            text.Should().Contain($"public sealed partial class {className} : global::Demo.ScrapeRequestFormatsItem");
            text.Should().Contain($"public override string Type => \"{stringValue}\";");
        }
        text.Should().Contain("public override bool IsBareString => true;");

        // Object variants: JsonFormat with prompt+maxItems; HighlightsFormat with query.
        text.Should().Contain("[global::Demo.AutoSDKPolymorphicFormatVariant(\"json\", typeof(global::Demo.JsonFormat))]");
        text.Should().Contain("public sealed partial class JsonFormat : global::Demo.ScrapeRequestFormatsItem");
        text.Should().Contain("public override string Type => \"json\";");
        text.Should().Contain("public string TypeValue { get; } = \"json\";");
        text.Should().Contain("[global::System.Text.Json.Serialization.JsonPropertyName(\"prompt\")]");
        text.Should().Contain("public string? Prompt { get; set; }");
        text.Should().Contain("[global::System.Text.Json.Serialization.JsonPropertyName(\"maxItems\")]");
        text.Should().Contain("public int? MaxItems { get; set; }");

        text.Should().Contain("[global::Demo.AutoSDKPolymorphicFormatVariant(\"highlights\", typeof(global::Demo.HighlightsFormat))]");
        text.Should().Contain("public sealed partial class HighlightsFormat : global::Demo.ScrapeRequestFormatsItem");
        text.Should().Contain("public override string Type => \"highlights\";");
        text.Should().Contain("public string? Query { get; set; }");
    }

    [TestMethod]
    public void Pipeline_WhenFlagOn_ReplacesConsumingPropertyTypeAndSkipsOneOfHelper()
    {
        var settings = BuildSettings(flag: true);
        var data = AutoSDK.Generation.Data.Prepare(((FirecrawlShapedSpec, settings), GlobalSettings: settings));

        data.AnyOfs.Should().BeEmpty("the matching array-items oneOf should resolve to the generated polymorphic base type instead of emitting a OneOf helper");

        var request = data.Classes.Single(x => x.ClassName == "ScrapeRequest");
        var formats = request.Properties.Single(x => x.Name == "Formats");

        formats.Type.CSharpType.Should().Be("global::System.Collections.Generic.IList<global::Demo.ScrapeRequestFormatsItem>?");
        formats.Type.CSharpTypeWithoutNullability.Should().Be("global::System.Collections.Generic.IList<global::Demo.ScrapeRequestFormatsItem>");
    }

    [TestMethod]
    public void Pipeline_WhenFlagOn_EmitsResolvedVariantPropertyTypes()
    {
        var settings = BuildSettings(flag: true);
        var data = AutoSDK.Generation.Data.Prepare(((RichPropertyTypesSpec, settings), GlobalSettings: settings));

        var file = Sources.PolymorphicArrayClasses(settings, data.Schemas).Single();
        var text = file.Text;

        text.Should().Contain("public global::Demo.ExtractionSchema? Schema { get; set; }");
        text.Should().Contain("public global::System.Collections.Generic.IList<global::Demo.Rule>? Rules { get; set; }");

        Regex.IsMatch(
                text,
                @"public global::Demo\.[A-Za-z0-9_]+\? Mode \{ get; set; \}",
                RegexOptions.CultureInvariant)
            .Should()
            .BeTrue("inline enum variant properties should use the generated enum type instead of object?");

        Regex.IsMatch(
                text,
                @"public global::Demo\.[A-Za-z0-9_]+\? Settings \{ get; set; \}",
                RegexOptions.CultureInvariant)
            .Should()
            .BeTrue("inline object variant properties should use the generated model type instead of object?");

        text.Should().NotContain("public object? Schema { get; set; }");
        text.Should().NotContain("public object? Mode { get; set; }");
        text.Should().NotContain("public object? Rules { get; set; }");
        text.Should().NotContain("public object? Settings { get; set; }");
    }

    [TestMethod]
    public void Pipeline_NonMatchingShape_EmitsNothing()
    {
        // Plain string array — not a polymorphic-format shape.
        const string plainSpec = """
                                  openapi: 3.0.3
                                  info:
                                    title: Plain
                                    version: 1.0.0
                                  paths:
                                    /plain:
                                      get:
                                        operationId: plain
                                        responses:
                                          '200':
                                            description: ok
                                  components:
                                    schemas:
                                      PlainRequest:
                                        type: object
                                        properties:
                                          tags:
                                            type: array
                                            items:
                                              type: string
                                  """;

        var settings = BuildSettings(flag: true);
        var data = AutoSDK.Generation.Data.Prepare(((plainSpec, settings), GlobalSettings: settings));

        var files = Sources.PolymorphicArrayClasses(settings, data.Schemas).ToArray();

        files.Should().BeEmpty();
    }

    [TestMethod]
    public void Pipeline_MissingTypedObjectVariant_EmitsNothing()
    {
        // oneOf has only string-enum variants - no typed-object variant - skip.
        const string stringOnlySpec = """
                                       openapi: 3.0.3
                                       info:
                                         title: StringOnly
                                         version: 1.0.0
                                       paths:
                                         /x:
                                           get:
                                             operationId: x
                                             responses:
                                               '200':
                                                 description: ok
                                       components:
                                         schemas:
                                           Req:
                                             type: object
                                             properties:
                                               kinds:
                                                 type: array
                                                 items:
                                                   oneOf:
                                                     - type: string
                                                       enum: [a, b]
                                                     - type: string
                                                       enum: [c, d]
                                       """;

        var settings = BuildSettings(flag: true);
        var data = AutoSDK.Generation.Data.Prepare(((stringOnlySpec, settings), GlobalSettings: settings));

        var files = Sources.PolymorphicArrayClasses(settings, data.Schemas).ToArray();

        files.Should().BeEmpty();
    }
}
