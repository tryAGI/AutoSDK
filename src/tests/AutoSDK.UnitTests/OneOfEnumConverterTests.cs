using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class OneOfEnumConverterTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net8.0",
        Namespace = "G",
        ClassName = "Api",
        JsonSerializerType = JsonSerializerType.SystemTextJson,
        GenerateSdk = true,
        GenerateModels = true,
        GenerateMethods = true,
    };

    [TestMethod]
    public void InlineOneOfOfEnumReferences_UsesQualifiedOneOfJsonConverter()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: enum-oneof
                              version: 1.0.0
                            paths:
                              /voices:
                                get:
                                  operationId: listVoices
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/VoiceWrapper'
                            components:
                              schemas:
                                LanguageCode:
                                  type: string
                                  enum:
                                    - en
                                AutoDetect:
                                  type: string
                                  enum:
                                    - auto
                                VoiceWrapper:
                                  type: object
                                  properties:
                                    language:
                                      oneOf:
                                        - $ref: '#/components/schemas/LanguageCode'
                                        - $ref: '#/components/schemas/AutoDetect'
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var generatedModel = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));

        generatedModel.Should().Contain(
            "[global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.LanguageCode?, global::G.AutoDetect?>))]");
        generatedModel.Should().Contain(
            "public global::G.OneOf<global::G.LanguageCode?, global::G.AutoDetect?>? Language { get; set; }");
        generatedModel.Should().NotContain(
            "JsonConverters.OneOf<global::G.LanguageCode?, global::G.AutoDetect?>JsonConverter");
    }

    [TestMethod]
    public void InlineOneOfOfInlineEnumsWithParentEnum_UsesQualifiedOneOfJsonConverter()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: enum-oneof-inline
                              version: 1.0.0
                            paths:
                              /voices:
                                get:
                                  operationId: listVoices
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/VoiceWrapper'
                            components:
                              schemas:
                                VoiceWrapper:
                                  type: object
                                  properties:
                                    language:
                                      description: Two letter ISO 639-1 language code. Use "auto" for auto-detection.
                                      enum:
                                        - en
                                        - auto
                                      oneOf:
                                        - type: string
                                          title: ISO 639-1 Language Code
                                          enum:
                                            - en
                                        - type: string
                                          title: Auto-detect
                                          enum:
                                            - auto
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var generatedModel = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));

        generatedModel.Should().Contain(
            "[global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<");
        generatedModel.Should().Contain(
            "public global::G.OneOf<");
        generatedModel.Should().NotContain(
            "JsonConverters.OneOf<");
        generatedModel.Should().NotContain(
            ">JsonConverter))]");
    }

    [TestMethod]
    public void InlineOneOfOfInlineEnumAndString_UsesQualifiedOneOfJsonConverter()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: enum-oneof-inline-string
                              version: 1.0.0
                            paths:
                              /test:
                                get:
                                  operationId: getTest
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/TestObject'
                            components:
                              schemas:
                                TestObject:
                                  type: object
                                  properties:
                                    voiceId:
                                      oneOf:
                                        - type: string
                                          title: Preset Voices
                                          enum:
                                            - amy
                                            - ansel
                                            - autumn
                                        - type: string
                                          title: Custom Voice ID
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var generatedModel = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));

        generatedModel.Should().Contain(
            "[global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<");
        generatedModel.Should().Contain(
            "public global::G.OneOf<");
        generatedModel.Should().Contain(
            "string");
        generatedModel.Should().NotContain(
            "JsonConverters.OneOf<");
        generatedModel.Should().NotContain(
            ">JsonConverter))]");
    }
}
