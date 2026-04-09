using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class EnumGenerationTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
        ClsCompliantEnumPrefix = "x",
    };

    [TestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public void EnumGeneration_EscapesQuotedStringValues(JsonSerializerType jsonSerializerType)
    {
        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = jsonSerializerType,
            TargetFramework = jsonSerializerType is JsonSerializerType.SystemTextJson
                ? "net8.0"
                : "net6.0",
        };

        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: QuotedEnum
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                TranscriptType:
                                  type: string
                                  enum:
                                    - transcript
                                    - 'transcript[transcriptType="final"]'
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var enumModel = data.Enums.Single(x => x.ClassName == "TranscriptType");
        var generatedEnum = Sources.GenerateEnumerationModel(enumModel);
        var generatedExtensions = Sources.GenerateEnumExtensions(enumModel);

        generatedExtensions.Should().Contain("=> \"transcript[transcriptType=\\\"final\\\"]\",");
        generatedExtensions.Should().Contain("\"transcript[transcriptType=\\\"final\\\"]\" =>");
        generatedExtensions.Should().NotContain("=> \"transcript[transcriptType=\"final\"]\",");

        if (jsonSerializerType is JsonSerializerType.NewtonsoftJson)
        {
            generatedEnum.Should().Contain("[global::System.Runtime.Serialization.EnumMember(Value=\"transcript[transcriptType=\\\"final\\\"]\")]");
        }
    }

    [TestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public void OpenEnumGeneration_PreservesUnknownValues(JsonSerializerType jsonSerializerType)
    {
        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = jsonSerializerType,
            TargetFramework = jsonSerializerType is JsonSerializerType.SystemTextJson
                ? "net8.0"
                : "net6.0",
        };

        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: OpenEnum
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Status:
                                  type: string
                                  x-speakeasy-unknown-values: allow
                                  enum:
                                    - active
                                    - inactive
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var enumModel = data.Enums.Single(x => x.ClassName == "Status");
        var generatedEnum = Sources.GenerateEnumerationModel(enumModel);
        var generatedExtensions = Sources.GenerateEnumExtensions(enumModel);
        var generatedConverter = Sources.GenerateEnumJsonConverter(enumModel);
        var generatedNullableConverter = Sources.GenerateEnumNullableJsonConverter(enumModel);

        enumModel.IsOpenEnum.Should().BeTrue();
        generatedEnum.Should().Contain("public readonly partial struct Status");
        generatedEnum.Should().Contain("public string Value { get; }");
        generatedEnum.Should().Contain("public static Status FromValue(string value)");
        generatedExtensions.Should().Contain("return Status.FromValue(value);");
        generatedConverter.Should().NotBeEmpty();
        generatedNullableConverter.Should().NotBeEmpty();

        if (jsonSerializerType is JsonSerializerType.NewtonsoftJson)
        {
            generatedConverter.Should().Contain("global::Newtonsoft.Json.JsonConverter<global::G.Status>");
            generatedConverter.Should().NotContain("JsonToken.Integer");

            var mainClient = data.Clients.First();
            mainClient.Converters.Should().Contain("global::G.JsonConverters.StatusJsonConverter");
            mainClient.Converters.Should().Contain("global::G.JsonConverters.StatusNullableJsonConverter");

            var generatedClient = Sources.GenerateClient(mainClient);
            generatedClient.Should().Contain("new global::G.JsonConverters.StatusJsonConverter(),");
            generatedClient.Should().Contain("new global::G.JsonConverters.StatusNullableJsonConverter(),");
        }
        else
        {
            generatedConverter.Should().Contain("global::System.Text.Json.Serialization.JsonConverter<global::G.Status>");
            generatedConverter.Should().NotContain("JsonTokenType.Number");
        }
    }
}
