using AutoSDK.Generation;

namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void GenerateClassJsonExtensions_WithJsonSerializerContext_GeneratesAotSafeParameterlessHelpers(bool useLegacyPrepare)
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Json Helper Context
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                ContextModel:
                                  type: object
                                  additionalProperties: false
                                  properties:
                                    name:
                                      type: string
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateRawModelData = true,
            GenerateJsonSerializerContextTypes = true,
            JsonSerializerContext = "TestNamespace.SourceGenerationContext",
        };

        var data = PrepareOpenApi(useLegacyPrepare, yaml, settings);
        var model = data.Classes.Single(x => x.ClassName == "ContextModel");
        var generatedJson = Sources.ClassJsonExtensions(model).Text;

        generatedJson.Should().Contain("""
        public string ToJson()
        {
            return ToJson(global::TestNamespace.SourceGenerationContext.Default);
        }
""");
        generatedJson.Should().Contain("""
            if (jsonSerializerOptions is null)
            {
                return ToJson(global::TestNamespace.SourceGenerationContext.Default);
            }
""");
        generatedJson.Should().Contain("""
        public static global::TestNamespace.ContextModel? FromJson(
            string json)
        {
            return FromJson(
                json,
                global::TestNamespace.SourceGenerationContext.Default);
        }
""");
        generatedJson.Should().Contain("""
        public static global::System.Threading.Tasks.ValueTask<global::TestNamespace.ContextModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream)
        {
            return FromJsonStreamAsync(
                jsonStream,
                global::TestNamespace.SourceGenerationContext.Default);
        }
""");
        generatedJson.Should().Contain("""
        public string ToRawJson()
        {
            return ToRawJson(global::TestNamespace.SourceGenerationContext.Default);
        }
""");
        generatedJson.Should().Contain("""
        public static global::TestNamespace.ContextModel? FromRawUnchecked(
            string json)
        {
            return FromRawUnchecked(
                json,
                global::TestNamespace.SourceGenerationContext.Default);
        }
""");
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void GenerateClassJsonExtensions_WithoutJsonSerializerContext_KeepsOptionsOnlyHelpers(bool useLegacyPrepare)
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Json Helper Options
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                OptionsModel:
                                  type: object
                                  properties:
                                    name:
                                      type: string
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
        };

        var data = PrepareOpenApi(useLegacyPrepare, yaml, settings);
        var model = data.Classes.Single(x => x.ClassName == "OptionsModel");
        var generatedJson = Sources.ClassJsonExtensions(model).Text;

        generatedJson.Should().NotContain("SourceGenerationContext.Default");
        generatedJson.Should().NotContain("""
        public string ToJson()
""");
        generatedJson.Should().NotContain("""
        public static global::TestNamespace.OptionsModel? FromJson(
            string json)
""");
        generatedJson.Should().NotContain("""
        public static global::System.Threading.Tasks.ValueTask<global::TestNamespace.OptionsModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream)
""");
    }
}
