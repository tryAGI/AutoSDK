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

    [TestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public void DiscriminatorEnumGeneration_RejectsUnknownValues(JsonSerializerType jsonSerializerType)
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

        const string json = """
                            {
                              "asyncapi": "3.0.0",
                              "info": { "title": "Realtime API", "version": "1.0.0" },
                              "channels": {
                                "realtime": {
                                  "address": "/realtime",
                                  "messages": {
                                    "KnownEvent": { "$ref": "#/components/messages/KnownEvent" },
                                    "OtherEvent": { "$ref": "#/components/messages/OtherEvent" }
                                  }
                                }
                              },
                              "operations": {
                                "receiveKnown": {
                                  "action": "receive",
                                  "channel": { "$ref": "#/channels/realtime" },
                                  "messages": [ { "$ref": "#/channels/realtime/messages/KnownEvent" } ]
                                },
                                "receiveOther": {
                                  "action": "receive",
                                  "channel": { "$ref": "#/channels/realtime" },
                                  "messages": [ { "$ref": "#/channels/realtime/messages/OtherEvent" } ]
                                }
                              },
                              "components": {
                                "messages": {
                                  "KnownEvent": {
                                    "name": "KnownEvent",
                                    "payload": { "$ref": "#/components/schemas/KnownEvent" }
                                  },
                                  "OtherEvent": {
                                    "name": "OtherEvent",
                                    "payload": { "$ref": "#/components/schemas/OtherEvent" }
                                  }
                                },
                                "schemas": {
                                  "KnownEvent": {
                                    "type": "object",
                                    "required": ["type"],
                                    "properties": {
                                      "type": { "type": "string", "enum": ["known"] }
                                    }
                                  },
                                  "OtherEvent": {
                                    "type": "object",
                                    "required": ["type"],
                                    "properties": {
                                      "type": { "type": "string", "enum": ["other"] }
                                    }
                                  },
                                  "OrdinaryStatus": {
                                    "type": "string",
                                    "enum": ["ready", "done"]
                                  }
                                }
                              }
                            }
                            """;

        var data = AsyncApiData.Prepare(((json, settings), GlobalSettings: settings));
        var discriminatorModel = data.Enums.Single(x => x.ClassName == "ServerEventDiscriminatorType");
        var ordinaryModel = data.Enums.Single(x => x.ClassName == "OrdinaryStatus");
        var discriminatorConverter = Sources.GenerateEnumJsonConverter(discriminatorModel);
        var ordinaryConverter = Sources.GenerateEnumJsonConverter(ordinaryModel);

        discriminatorModel.RejectUnknownStringValues.Should().BeTrue();
        ordinaryModel.RejectUnknownStringValues.Should().BeFalse();
        discriminatorConverter.Should().Contain("Unknown discriminator value '{stringValue}'");
        ordinaryConverter.Should().Contain("Extensions.ToEnum(stringValue) ?? default;");

        if (jsonSerializerType is JsonSerializerType.NewtonsoftJson)
        {
            discriminatorConverter.Should().Contain("throw new global::Newtonsoft.Json.JsonSerializationException");
        }
        else
        {
            discriminatorConverter.Should().Contain("throw new global::System.Text.Json.JsonException");
        }
    }

    [TestMethod]
    public void EnumPathParameters_UseWireValues()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
        };

        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: EnumPath
                              version: 1.0.0
                            paths:
                              /v1/single-use-token/{token_type}:
                                get:
                                  operationId: createSingleUseToken
                                  parameters:
                                    - in: path
                                      name: token_type
                                      required: true
                                      schema:
                                        type: string
                                        enum:
                                          - realtime_scribe
                                          - text_to_speech
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            properties:
                                              token:
                                                type: string
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var method = data.Methods.Single();
        var methodSource = Sources.GenerateEndPoint(method);

        method.Path.Should()
            .Contain("{(global::System.Uri.EscapeDataString(tokenType.ToValueString()))}");
        methodSource.Should()
            .Contain("path: $\"/v1/single-use-token/{(global::System.Uri.EscapeDataString(tokenType.ToValueString()))}\"");
        methodSource.Should().NotContain("path: $\"/v1/single-use-token/{tokenType}\"");
    }
}
