using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
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

    private const string NamespaceDelimitedSpec = """
                                                 openapi: 3.1.0
                                                 info:
                                                   title: Namespace Delimiter Demo
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
                                                               $ref: '#/components/schemas/Provider.ScrapeRequest'
                                                       responses:
                                                         '200':
                                                           description: ok
                                                 components:
                                                   schemas:
                                                     Provider.ScrapeRequest:
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
                                                                   prompt:
                                                                     type: string
                                                 """;

    private const string CollidingVariantNamesSpec = """
                                                     openapi: 3.1.0
                                                     info:
                                                       title: Colliding Variant Demo
                                                       version: 1.0.0
                                                     paths:
                                                       /first:
                                                         post:
                                                           operationId: first
                                                           requestBody:
                                                             required: true
                                                             content:
                                                               application/json:
                                                                 schema:
                                                                   $ref: '#/components/schemas/FirstRequest'
                                                           responses:
                                                             '200':
                                                               description: ok
                                                       /second:
                                                         post:
                                                           operationId: second
                                                           requestBody:
                                                             required: true
                                                             content:
                                                               application/json:
                                                                 schema:
                                                                   $ref: '#/components/schemas/SecondRequest'
                                                           responses:
                                                             '200':
                                                               description: ok
                                                     components:
                                                       schemas:
                                                         FirstRequest:
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
                                                                       prompt:
                                                                         type: string
                                                         SecondRequest:
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
                                                                       prompt:
                                                                         type: string
                                                     """;

    private const string ExistingGeneratedTypeCollisionSpec = """
                                                              openapi: 3.1.0
                                                              info:
                                                                title: Existing Generated Type Collision Demo
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
                                                                  MarkdownFormat:
                                                                    type: object
                                                                    properties:
                                                                      label:
                                                                        type: string
                                                                  JsonFormat:
                                                                    type: string
                                                                    enum: [strict, lenient]
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
                                                                                mode:
                                                                                  $ref: '#/components/schemas/JsonFormat'
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

    private static Settings BuildContextSettings(bool flag) => BuildSettings(flag) with
    {
        FromCli = true,
        GenerateMethods = false,
        GenerateSdk = false,
        GenerateJsonSerializerContextTypes = true,
        JsonSerializerContext = "Demo.SourceGenerationContext",
        JsonSerializerType = JsonSerializerType.SystemTextJson,
        TargetFramework = "net10.0",
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
    public void Pipeline_WhenFlagOn_RegistersGeneratedVariantsAndSuppressesLegacyArtifacts()
    {
        var settings = BuildContextSettings(flag: true);
        var data = CSharpPipeline.PrepareAndEnrich(((FirecrawlShapedSpec, settings), settings));

        data.Classes.Select(static model => model.ClassName)
            .Should()
            .Equal("ScrapeRequest");
        data.Enums.Should().BeEmpty("the rewritten polymorphic-array variants should no longer emit inline enum wrappers");

        var emittedTypeNames = data.Types
            .Select(static type => type.CSharpTypeWithoutNullability)
            .ToArray();

        emittedTypeNames.Should().Contain(
        [
            "global::Demo.ScrapeRequestFormatsItem",
            "global::Demo.MarkdownFormat",
            "global::Demo.HtmlFormat",
            "global::Demo.LinksFormat",
            "global::Demo.JsonFormat",
            "global::Demo.HighlightsFormat",
        ]);
        emittedTypeNames.Should().NotContain(
            static typeName => typeName.Contains("FormatEnum", StringComparison.Ordinal),
            "the old inline oneOf helper artifacts should disappear once the array is rewritten to the generated hierarchy");

        var jsonSerializerContext = CSharpPipeline.GenerateFiles(data)
            .Single(static file => file.Name.EndsWith("JsonSerializerContext.g.cs", StringComparison.Ordinal));

        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.MarkdownFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.HtmlFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.LinksFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.JsonFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.HighlightsFormat)");
    }

    [TestMethod]
    public void GeneratedFiles_WhenFlagOn_CompileAndRoundTripPolymorphicArraysWithSourceGeneratedContext()
    {
        var settings = BuildContextSettings(flag: true);
        var data = CSharpPipeline.PrepareAndEnrich(((FirecrawlShapedSpec, settings), settings));
        var files = CSharpPipeline.GenerateFiles(data);
        var assembly = CompileGeneratedAssembly("DemoPolymorphicRoundTrip", files);

        var requestType = assembly.GetType("Demo.ScrapeRequest", throwOnError: true)!;
        var baseType = assembly.GetType("Demo.ScrapeRequestFormatsItem", throwOnError: true)!;
        var markdownType = assembly.GetType("Demo.MarkdownFormat", throwOnError: true)!;
        var jsonFormatType = assembly.GetType("Demo.JsonFormat", throwOnError: true)!;
        var highlightsType = assembly.GetType("Demo.HighlightsFormat", throwOnError: true)!;
        var contextType = assembly.GetType("Demo.SourceGenerationContext", throwOnError: true)!;

        var request = Activator.CreateInstance(requestType)
            ?? throw new InvalidOperationException("Failed to create ScrapeRequest instance.");
        var formats = (IList)(Activator.CreateInstance(typeof(List<>).MakeGenericType(baseType))
            ?? throw new InvalidOperationException("Failed to create formats list."));

        formats.Add(Activator.CreateInstance(markdownType)
            ?? throw new InvalidOperationException("Failed to create MarkdownFormat instance."));

        var jsonFormat = Activator.CreateInstance(jsonFormatType)
            ?? throw new InvalidOperationException("Failed to create JsonFormat instance.");
        SetPropertyValue(jsonFormat, "Prompt", "Extract entities");
        SetPropertyValue(jsonFormat, "MaxItems", 3);
        formats.Add(jsonFormat);

        var highlights = Activator.CreateInstance(highlightsType)
            ?? throw new InvalidOperationException("Failed to create HighlightsFormat instance.");
        SetPropertyValue(highlights, "Query", "key facts");
        formats.Add(highlights);

        SetPropertyValue(request, "Formats", formats);

        var context = (JsonSerializerContext)(contextType
            .GetProperty("Default", BindingFlags.Public | BindingFlags.Static)?
            .GetValue(null)
            ?? throw new InvalidOperationException("SourceGenerationContext.Default was not generated."));

        var json = JsonSerializer.Serialize(request, requestType, context);

        json.Should().Be(
            "{\"formats\":[\"markdown\",{\"type\":\"json\",\"prompt\":\"Extract entities\",\"maxItems\":3},{\"type\":\"highlights\",\"query\":\"key facts\"}]}");

        var roundTrippedRequest = JsonSerializer.Deserialize(json, requestType, context);
        roundTrippedRequest.Should().NotBeNull();

        var roundTrippedFormats = ((IEnumerable?)requestType.GetProperty("Formats")?.GetValue(roundTrippedRequest))
            ?.Cast<object>()
            .ToArray();

        roundTrippedFormats.Should().NotBeNull();
        roundTrippedFormats!.Select(static item => item.GetType().Name)
            .Should()
            .Equal("MarkdownFormat", "JsonFormat", "HighlightsFormat");
        GetPropertyValue(roundTrippedFormats[1], "Prompt").Should().Be("Extract entities");
        GetPropertyValue(roundTrippedFormats[1], "MaxItems").Should().Be(3);
        GetPropertyValue(roundTrippedFormats[2], "Query").Should().Be("key facts");
    }

    [TestMethod]
    public void Pipeline_WithNamespaceDelimiter_EmitsPolymorphicTypesInGeneratedNamespace()
    {
        var settings = BuildContextSettings(flag: true) with
        {
            NamespaceDelimiter = ".",
        };
        var data = CSharpPipeline.PrepareAndEnrich(((NamespaceDelimitedSpec, settings), settings));
        var files = CSharpPipeline.GenerateFiles(data);

        var request = data.Classes.Single(x => x.GlobalClassName == "global::Demo.Provider.ScrapeRequest");
        var formats = request.Properties.Single(x => x.Name == "Formats");
        formats.Type.CSharpType.Should().Be("global::System.Collections.Generic.IList<global::Demo.Provider.ScrapeRequestFormatsItem>?");

        var polymorphicFile = files.Single(static file => file.Name == "Demo.Provider.Models.ScrapeRequestFormatsItem.g.cs");
        polymorphicFile.Text.Should().Contain("namespace Demo.Provider");
        polymorphicFile.Text.Should().Contain("typeof(global::Demo.Provider.MarkdownFormat)");
        polymorphicFile.Text.Should().Contain("typeof(global::Demo.Provider.JsonFormat)");
        polymorphicFile.Text.Should().Contain("global::Demo.AutoSDKPolymorphicFormatJsonConverter<global::Demo.Provider.ScrapeRequestFormatsItem>");
        polymorphicFile.Text.Should().Contain("public abstract partial class ScrapeRequestFormatsItem : global::Demo.AutoSDKPolymorphicFormat");

        data.Types.Select(static type => type.CSharpTypeWithoutNullability)
            .Should()
            .Contain(
            [
                "global::Demo.Provider.ScrapeRequestFormatsItem",
                "global::Demo.Provider.MarkdownFormat",
                "global::Demo.Provider.JsonFormat",
            ]);

        var jsonSerializerContext = files.Single(static file => file.Name.EndsWith("JsonSerializerContext.g.cs", StringComparison.Ordinal));
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.Provider.ScrapeRequestFormatsItem)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.Provider.MarkdownFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.Provider.JsonFormat)");

        var assembly = CompileGeneratedAssembly("DemoPolymorphicNestedNamespace", files);
        assembly.GetType("Demo.Provider.ScrapeRequestFormatsItem", throwOnError: true).Should().NotBeNull();
        assembly.GetType("Demo.Provider.MarkdownFormat", throwOnError: true).Should().NotBeNull();
        assembly.GetType("Demo.Provider.JsonFormat", throwOnError: true).Should().NotBeNull();
    }

    [TestMethod]
    public void Pipeline_WhenVariantNamesCollideAcrossMatches_ScopesSubclassNamesPerBaseType()
    {
        var settings = BuildContextSettings(flag: true);
        var data = CSharpPipeline.PrepareAndEnrich(((CollidingVariantNamesSpec, settings), settings));
        var files = CSharpPipeline.GenerateFiles(data);

        data.Types.Select(static type => type.CSharpTypeWithoutNullability)
            .Should()
            .Contain(
            [
                "global::Demo.FirstRequestFormatsItem",
                "global::Demo.SecondRequestFormatsItem",
                "global::Demo.FirstRequestFormatsItemMarkdownFormat",
                "global::Demo.SecondRequestFormatsItemMarkdownFormat",
                "global::Demo.FirstRequestFormatsItemJsonFormat",
                "global::Demo.SecondRequestFormatsItemJsonFormat",
            ]);
        data.Types.Select(static type => type.CSharpTypeWithoutNullability)
            .Should()
            .NotContain(
            [
                "global::Demo.MarkdownFormat",
                "global::Demo.JsonFormat",
            ]);

        var firstFile = files.Single(static file => file.Name == "Demo.Models.FirstRequestFormatsItem.g.cs");
        firstFile.Text.Should().Contain("typeof(global::Demo.FirstRequestFormatsItemMarkdownFormat)");
        firstFile.Text.Should().Contain("typeof(global::Demo.FirstRequestFormatsItemJsonFormat)");
        firstFile.Text.Should().NotContain("typeof(global::Demo.MarkdownFormat)");
        firstFile.Text.Should().NotContain("typeof(global::Demo.JsonFormat)");

        var secondFile = files.Single(static file => file.Name == "Demo.Models.SecondRequestFormatsItem.g.cs");
        secondFile.Text.Should().Contain("typeof(global::Demo.SecondRequestFormatsItemMarkdownFormat)");
        secondFile.Text.Should().Contain("typeof(global::Demo.SecondRequestFormatsItemJsonFormat)");
        secondFile.Text.Should().NotContain("typeof(global::Demo.MarkdownFormat)");
        secondFile.Text.Should().NotContain("typeof(global::Demo.JsonFormat)");

        var jsonSerializerContext = files.Single(static file => file.Name.EndsWith("JsonSerializerContext.g.cs", StringComparison.Ordinal));
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.FirstRequestFormatsItemMarkdownFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.SecondRequestFormatsItemMarkdownFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.FirstRequestFormatsItemJsonFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.SecondRequestFormatsItemJsonFormat)");

        var assembly = CompileGeneratedAssembly("DemoPolymorphicVariantCollisions", files);
        assembly.GetType("Demo.FirstRequestFormatsItemMarkdownFormat", throwOnError: true).Should().NotBeNull();
        assembly.GetType("Demo.SecondRequestFormatsItemMarkdownFormat", throwOnError: true).Should().NotBeNull();
        assembly.GetType("Demo.FirstRequestFormatsItemJsonFormat", throwOnError: true).Should().NotBeNull();
        assembly.GetType("Demo.SecondRequestFormatsItemJsonFormat", throwOnError: true).Should().NotBeNull();
    }

    [TestMethod]
    public void Pipeline_WhenVariantNamesCollideWithExistingGeneratedTypes_ScopesPolymorphicSubclassNames()
    {
        var settings = BuildContextSettings(flag: true);
        var data = CSharpPipeline.PrepareAndEnrich(((ExistingGeneratedTypeCollisionSpec, settings), settings));
        var files = CSharpPipeline.GenerateFiles(data);

        data.Types.Select(static type => type.CSharpTypeWithoutNullability)
            .Should()
            .Contain(
            [
                "global::Demo.MarkdownFormat",
                "global::Demo.JsonFormat",
                "global::Demo.ScrapeRequestFormatsItem",
                "global::Demo.ScrapeRequestFormatsItemMarkdownFormat",
                "global::Demo.ScrapeRequestFormatsItemJsonFormat",
            ]);

        var polymorphicFile = files.Single(static file => file.Name == "Demo.Models.ScrapeRequestFormatsItem.g.cs");
        polymorphicFile.Text.Should().Contain("typeof(global::Demo.ScrapeRequestFormatsItemMarkdownFormat)");
        polymorphicFile.Text.Should().Contain("typeof(global::Demo.ScrapeRequestFormatsItemJsonFormat)");
        polymorphicFile.Text.Should().Contain("public sealed partial class ScrapeRequestFormatsItemMarkdownFormat : global::Demo.ScrapeRequestFormatsItem");
        polymorphicFile.Text.Should().Contain("public sealed partial class ScrapeRequestFormatsItemJsonFormat : global::Demo.ScrapeRequestFormatsItem");
        polymorphicFile.Text.Should().Contain("public global::Demo.JsonFormat? Mode { get; set; }");
        polymorphicFile.Text.Should().NotContain("[global::Demo.AutoSDKPolymorphicFormatVariant(\"markdown\", typeof(global::Demo.MarkdownFormat))]");
        polymorphicFile.Text.Should().NotContain("[global::Demo.AutoSDKPolymorphicFormatVariant(\"json\", typeof(global::Demo.JsonFormat))]");

        var jsonSerializerContext = files.Single(static file => file.Name.EndsWith("JsonSerializerContext.g.cs", StringComparison.Ordinal));
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.MarkdownFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.JsonFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.ScrapeRequestFormatsItemMarkdownFormat)");
        jsonSerializerContext.Text.Should().Contain("typeof(global::Demo.ScrapeRequestFormatsItemJsonFormat)");

        var assembly = CompileGeneratedAssembly("DemoPolymorphicGeneratedTypeCollisions", files);
        assembly.GetType("Demo.MarkdownFormat", throwOnError: true).Should().NotBeNull();
        assembly.GetType("Demo.JsonFormat", throwOnError: true).Should().NotBeNull();
        assembly.GetType("Demo.ScrapeRequestFormatsItemMarkdownFormat", throwOnError: true)!.BaseType!.FullName
            .Should().Be("Demo.ScrapeRequestFormatsItem");
        Nullable.GetUnderlyingType(
                assembly.GetType("Demo.ScrapeRequestFormatsItemJsonFormat", throwOnError: true)!.GetProperty("Mode")!.PropertyType)!
            .FullName
            .Should().Be("Demo.JsonFormat");
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

    private static Assembly CompileGeneratedAssembly(
        string assemblyName,
        IReadOnlyList<FileWithName> files)
    {
        var parseOptions = new CSharpParseOptions(documentationMode: DocumentationMode.Diagnose);
        var syntaxTrees = files
            .Select(file => CSharpSyntaxTree.ParseText(
                file.Text,
                parseOptions,
                path: file.Name))
            .ToArray();

        var references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator)
            .Where(static path => !string.IsNullOrWhiteSpace(path))
            .Select(static path => MetadataReference.CreateFromFile(path))
            .ToArray();

        var compilation = CSharpCompilation.Create(
            assemblyName,
            syntaxTrees,
            references,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        CSharpGeneratorDriver.Create(
                generators: [CreateSystemTextJsonSourceGenerator()],
                parseOptions: parseOptions)
            .RunGeneratorsAndUpdateCompilation(compilation, out var updatedCompilation, out var generatorDiagnostics);

        var compileDiagnostics = updatedCompilation.GetDiagnostics()
            .Where(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
            .Concat(generatorDiagnostics.Where(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error))
            .Select(static diagnostic => diagnostic.ToString())
            .ToArray();

        compileDiagnostics.Should().BeEmpty(
            "generated polymorphic-array files should compile together with the source-generated STJ context. Found:{0}{1}",
            Environment.NewLine,
            string.Join(Environment.NewLine + Environment.NewLine, compileDiagnostics));

        using var peStream = new MemoryStream();
        var emitResult = updatedCompilation.Emit(peStream);
        emitResult.Success.Should().BeTrue(
            "the emitted polymorphic-array assembly should succeed. Found:{0}{1}",
            Environment.NewLine,
            string.Join(
                Environment.NewLine + Environment.NewLine,
                emitResult.Diagnostics
                    .Where(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                    .Select(static diagnostic => diagnostic.ToString())));

        return Assembly.Load(peStream.ToArray());
    }

    private static ISourceGenerator CreateSystemTextJsonSourceGenerator()
    {
        var generatorAssembly = Assembly.LoadFrom(GetSystemTextJsonSourceGeneratorAssemblyPath());
        var generatorType = generatorAssembly.GetType(
            "System.Text.Json.SourceGeneration.JsonSourceGenerator",
            throwOnError: true)
            ?? throw new InvalidOperationException("System.Text.Json source generator type was not found.");
        var generator = Activator.CreateInstance(generatorType)
            ?? throw new InvalidOperationException("Failed to create the System.Text.Json source generator.");

        return generator switch
        {
            ISourceGenerator sourceGenerator => sourceGenerator,
            IIncrementalGenerator incrementalGenerator => incrementalGenerator.AsSourceGenerator(),
            _ => throw new InvalidOperationException(
                $"Unsupported System.Text.Json source generator shape: {generator.GetType().FullName}."),
        };
    }

    private static string GetSystemTextJsonSourceGeneratorAssemblyPath()
    {
        var runtimeDirectory = Path.GetDirectoryName(typeof(object).Assembly.Location)
            ?? throw new InvalidOperationException("Could not resolve the runtime directory.");
        var dotnetRoot = Path.GetFullPath(Path.Combine(runtimeDirectory, "..", "..", ".."));
        var runtimeVersion = new DirectoryInfo(runtimeDirectory).Name;
        var exactMatch = Path.Combine(
            dotnetRoot,
            "packs",
            "Microsoft.NETCore.App.Ref",
            runtimeVersion,
            "analyzers",
            "dotnet",
            "cs",
            "System.Text.Json.SourceGeneration.dll");

        if (File.Exists(exactMatch))
        {
            return exactMatch;
        }

        var fallback = Directory.GetFiles(
                Path.Combine(dotnetRoot, "packs"),
                "System.Text.Json.SourceGeneration.dll",
                SearchOption.AllDirectories)
            .Where(path => path.Contains(
                $"{Path.DirectorySeparatorChar}Microsoft.NETCore.App.Ref{Path.DirectorySeparatorChar}",
                StringComparison.Ordinal))
            .OrderByDescending(static path => path, StringComparer.Ordinal)
            .FirstOrDefault();

        return fallback
            ?? throw new InvalidOperationException("Could not locate System.Text.Json.SourceGeneration.dll.");
    }

    private static void SetPropertyValue(object instance, string propertyName, object? value)
    {
        instance.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public)?
            .SetValue(instance, value);
    }

    private static object? GetPropertyValue(object instance, string propertyName)
    {
        return instance.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public)?
            .GetValue(instance);
    }
}
