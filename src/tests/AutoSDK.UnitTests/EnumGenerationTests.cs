using AutoSDK.Generation;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using System.Text.Json.Nodes;

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
    [DataRow(JsonSerializerType.SystemTextJson, false)]
    [DataRow(JsonSerializerType.SystemTextJson, true)]
    [DataRow(JsonSerializerType.NewtonsoftJson, false)]
    [DataRow(JsonSerializerType.NewtonsoftJson, true)]
    public void RejectUnknownEnumValues_CoversMultiValueEnumsOnlyWhenRequested(JsonSerializerType serializer, bool reject)
    {
        // Without this flag the converters read an unknown value as `ToEnum(v) ?? default`, so a value
        // the spec does not declare silently becomes the first member. ValidateAnyOfs only covers
        // single-literal discriminators, which leaves every ordinary enum coercing.
        const string spec = """
        openapi: 3.0.3
        info: { title: Enum input validation, version: '1' }
        paths: {}
        components:
          schemas:
            Flavor: { type: string, enum: [vivid, natural] }
            Literal: { type: string, enum: [alpha] }
            Open: { type: string, enum: [alpha, beta], x-speakeasy-unknown-values: allow }
        """;
        var settings = DefaultSettings with { JsonSerializerType = serializer, RejectUnknownEnumValues = reject };
        var data = AutoSDK.Generation.Data.Prepare(((spec, settings), settings));

        data.Enums.Single(x => x.ClassName == "Flavor").RejectUnknownStringValues.Should().Be(reject);
        data.Enums.Single(x => x.ClassName == "Literal").RejectUnknownStringValues.Should().Be(reject);

        // An open enum keeps its documented leniency either way.
        data.Enums.Single(x => x.ClassName == "Open").RejectUnknownStringValues.Should().BeFalse();
    }

    [TestMethod]
    public void RejectUnknownEnumValues_TreatsACallbackPayloadAsInbound()
    {
        // Same inversion as a webhook, reached the other way: an operation's `callbacks` describe the
        // service calling back into the client, so the callback's requestBody is read, not written.
        // AssemblyAI is the case — its callback carries a transcript status, and hardening that would
        // throw the day AssemblyAI adds a value to it.
        const string spec = """
        openapi: 3.1.0
        info: { title: Callback direction, version: '1' }
        paths:
          /jobs:
            post:
              operationId: createJob
              requestBody:
                required: true
                content:
                  application/json:
                    schema:
                      type: object
                      properties:
                        quality: { $ref: '#/components/schemas/RequestOnly' }
              responses:
                '200': { description: ok }
              callbacks:
                jobDone:
                  '{$request.body#/callbackUrl}':
                    post:
                      operationId: onJobDone
                      requestBody:
                        required: true
                        content:
                          application/json:
                            schema:
                              type: object
                              properties:
                                status: { $ref: '#/components/schemas/CallbackStatus' }
                      responses:
                        '200': { description: acknowledged }
        components:
          schemas:
            RequestOnly: { type: string, enum: [fast, slow] }
            CallbackStatus: { type: string, enum: [ready, failed] }
        """;
        var settings = DefaultSettings with { RejectUnknownEnumValues = true };
        var data = AutoSDK.Generation.Data.Prepare(((spec, settings), settings));

        data.Enums.Single(x => x.ClassName == "RequestOnly").RejectUnknownStringValues.Should().BeTrue();
        data.Enums.Single(x => x.ClassName == "CallbackStatus").RejectUnknownStringValues.Should().BeFalse(
            "a callback payload is deserialized by the SDK, so an undeclared value means the service " +
            "shipped something new rather than that a caller made a mistake");
    }

    [TestMethod]
    public void RejectUnknownEnumValues_TreatsAWebhookPayloadAsInbound()
    {
        // A webhook is an inbound operation: its requestBody is what the service sends and the SDK
        // deserializes. Classifying that as request-direction — written by the SDK — is backwards, and
        // it is how Gladia came out with 57 hardened converters including its webhook and callback
        // event enums, which would have thrown the day Gladia added an event.
        const string spec = """
        openapi: 3.1.0
        info: { title: Webhook direction, version: '1' }
        paths:
          /jobs:
            post:
              operationId: createJob
              requestBody:
                required: true
                content:
                  application/json:
                    schema:
                      type: object
                      properties:
                        quality: { $ref: '#/components/schemas/RequestOnly' }
              responses:
                '200': { description: ok }
        webhooks:
          jobFinished:
            post:
              operationId: onJobFinished
              requestBody:
                required: true
                content:
                  application/json:
                    schema:
                      type: object
                      properties:
                        event: { $ref: '#/components/schemas/WebhookEvent' }
              responses:
                '200': { description: acknowledged }
        components:
          schemas:
            RequestOnly: { type: string, enum: [fast, slow] }
            WebhookEvent: { type: string, enum: [finished, failed] }
        """;
        var settings = DefaultSettings with { RejectUnknownEnumValues = true };
        var data = AutoSDK.Generation.Data.Prepare(((spec, settings), settings));

        // Reached only through a real request body, so an undeclared value is the caller's typo.
        data.Enums.Single(x => x.ClassName == "RequestOnly").RejectUnknownStringValues.Should().BeTrue();

        // Reached only through a webhook's requestBody, which the SDK reads rather than writes.
        data.Enums.Single(x => x.ClassName == "WebhookEvent").RejectUnknownStringValues.Should().BeFalse(
            "a webhook payload is deserialized by the SDK, so an undeclared value means the service " +
            "shipped something new rather than that a caller made a mistake");
    }

    [TestMethod]
    [DataRow(false, false)]
    [DataRow(true, true)]
    public void RejectUnknownEnumValues_NarrowsSingleValueResponseEnumsUnlessValidateAnyOfsOwnsThem(
        bool validateAnyOfs,
        bool expectedStrict)
    {
        // A one-value enum in a response is still a response. Firecrawl's `DELETE /crawl/{id}` answers
        // with `status: "cancelled"` declared exactly this way, and hardening it would throw on a
        // successful cancel the day the service spells the word differently or adds a state.
        //
        // The exception is ValidateAnyOfs, which hardens single-literal discriminators for reasons that
        // have nothing to do with direction. Where that setting is the source, the strictness stays, so
        // this narrowing cannot move the snapshots the discriminator path produces.
        const string spec = """
        openapi: 3.0.3
        info: { title: Single value response enum, version: '1' }
        paths:
          /jobs/{id}:
            delete:
              operationId: cancelJob
              parameters:
                - { name: id, in: path, required: true, schema: { type: string } }
              responses:
                '200':
                  description: cancelled
                  content:
                    application/json:
                      schema:
                        type: object
                        properties:
                          status: { type: string, enum: [cancelled] }
        """;
        var settings = DefaultSettings with
        {
            RejectUnknownEnumValues = true,
            ValidateAnyOfs = validateAnyOfs,
        };
        var data = AutoSDK.Generation.Data.Prepare(((spec, settings), settings));

        var status = data.Enums.Single(x => x.ClassName.EndsWith("Status", StringComparison.Ordinal));
        status.EnumValues.Should().HaveCount(1, "the spec declares exactly one value");
        status.RejectUnknownStringValues.Should().Be(expectedStrict);
    }

    [TestMethod]
    public void RejectUnknownEnumValues_LeavesEnumsThatAreReadOffTheWireLenient()
    {
        // The converters are emitted per type and the same one deserializes responses, so hardening a
        // response-reachable enum turns a service adding a value into an exception on a normal reply.
        // Runway is the case that proved it: with the flag on, 243 of its converters go strict,
        // including the task status read on every poll and an enum of model ids the account returns
        // that the spec is already known not to list.
        const string spec = """
        openapi: 3.0.3
        info: { title: Enum direction, version: '1' }
        paths:
          /submit:
            post:
              operationId: submit
              requestBody:
                required: true
                content:
                  application/json:
                    schema:
                      type: object
                      properties:
                        quality: { $ref: '#/components/schemas/RequestOnly' }
                        shared: { $ref: '#/components/schemas/Bidirectional' }
              responses:
                '200':
                  description: ok
                  content:
                    application/json:
                      schema:
                        type: object
                        properties:
                          status: { $ref: '#/components/schemas/ResponseOnly' }
                          shared: { $ref: '#/components/schemas/Bidirectional' }
        components:
          schemas:
            RequestOnly: { type: string, enum: [vivid, natural] }
            ResponseOnly: { type: string, enum: [pending, done] }
            Bidirectional: { type: string, enum: [left, right] }
            Unreachable: { type: string, enum: [alpha, beta] }
        """;
        var settings = DefaultSettings with { RejectUnknownEnumValues = true };
        var data = AutoSDK.Generation.Data.Prepare(((spec, settings), settings));

        // Caller input: a typo here is a mistake, so it should fail loudly.
        data.Enums.Single(x => x.ClassName == "RequestOnly").RejectUnknownStringValues.Should().BeTrue();

        // Read off the wire, so leniency is what lets the service move ahead of the spec.
        data.Enums.Single(x => x.ClassName == "ResponseOnly").RejectUnknownStringValues.Should().BeFalse();

        // One converter serves both directions and cannot be strict in one and lenient in the other,
        // so the response side decides.
        data.Enums.Single(x => x.ClassName == "Bidirectional").RejectUnknownStringValues.Should().BeFalse();

        // Strictness needs positive evidence of caller input. An enum no operation reaches has none,
        // so it is left lenient: Gladia declares its callback payload schemas as unreferenced
        // components, and hardening those would throw on a callback the day the service adds an event.
        // The models-only case — a spec with no paths at all, where there is no direction data to go on
        // — is covered by RejectUnknownEnumValues_CoversMultiValueEnumsOnlyWhenRequested instead.
        data.Enums.Single(x => x.ClassName == "Unreachable").RejectUnknownStringValues.Should().BeFalse();
    }

    [TestMethod]
    public void RejectUnknownEnumValues_IsOffByDefaultSoResponsesStayLenient()
    {
        // The same converters read responses, where a service adding an enum value must not break
        // existing clients. That is why this is opt-in rather than the new default.
        Settings.Default.RejectUnknownEnumValues.Should().BeFalse();
    }

    [TestMethod]
    [DataRow(JsonSerializerType.SystemTextJson, false)]
    [DataRow(JsonSerializerType.SystemTextJson, true)]
    [DataRow(JsonSerializerType.NewtonsoftJson, false)]
    [DataRow(JsonSerializerType.NewtonsoftJson, true)]
    public void OpenApiUnionValidation_RejectsClosedLiteralStringsOnlyWhenRequested(JsonSerializerType serializer, bool validate)
    {
        const string spec = """
        openapi: 3.0.3
        info: { title: Literal validation, version: '1' }
        paths: {}
        components:
          schemas:
            Literal: { type: string, enum: [alpha] }
            Multiple: { type: string, enum: [alpha, beta] }
            Open: { type: string, enum: [alpha], x-speakeasy-unknown-values: allow }
        """;
        var settings = DefaultSettings with { JsonSerializerType = serializer, ValidateAnyOfs = validate };
        var data = AutoSDK.Generation.Data.Prepare(((spec, settings), settings));
        var literal = data.Enums.Single(x => x.ClassName == "Literal");
        literal.RejectUnknownStringValues.Should().Be(validate);
        Sources.GenerateEnumJsonConverter(literal).Should().Contain(validate ? "throw new" : "?? default");
        data.Enums.Single(x => x.ClassName == "Multiple").RejectUnknownStringValues.Should().BeFalse();
        data.Enums.Single(x => x.ClassName == "Open").RejectUnknownStringValues.Should().BeFalse();
    }

    [TestMethod]
    public void BooleanEnumDefault_EmitsBooleanLiteral()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: BooleanEnumDefault
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                TestResult:
                                  type: object
                                  required: [success]
                                  properties:
                                    success:
                                      type: boolean
                                      enum: [true]
                                      default: true
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var model = data.Classes.Single(x => x.ClassName == "TestResult");
        var generatedModel = Sources.GenerateModel(model);

        model.Properties.Single(x => x.Name == "Success").DefaultValue.Should().Be("true");
        generatedModel.Should().NotContain("bool.True");
    }

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
    public void OpenEnumGeneration_AvoidsGeneratedStructMemberNames()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Operator Enum
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Operator:
                                  type: string
                                  x-speakeasy-unknown-values: allow
                                  enum: [equals, equals_value, value, from_value, is_known, operator]
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var model = data.Enums.Single(x => x.ClassName == "Operator");
        var names = model.EnumValues.ToDictionary(static value => value.Id, static value => value.Name);
        var generated = Sources.GenerateEnumerationModel(model);

        model.IsOpenEnum.Should().BeTrue();
        names["equals"].Should().Be("EqualsValue");
        names["equals_value"].Should().Be("EqualsValue2");
        names["value"].Should().Be("ValueValue");
        names["from_value"].Should().Be("FromValueValue");
        names["is_known"].Should().Be("IsKnownValue");
        names["operator"].Should().Be("OperatorValue");
        generated.Should().Contain("new(\"equals\")");
        generated.Should().NotContain("public static Operator Equals { get; }");
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
        // One wording for every closed enum: the converter rejects any undeclared value, and a
        // discriminator is only the case where that was already switched on.
        discriminatorConverter.Should().Contain("Unknown value '{stringValue}'");
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

    [TestMethod]
    public void EnumGeneration_DisambiguatesCaseInsensitiveMemberNameCollisions()
    {
        IList<JsonNode> values =
        [
            JsonValue.Create("ready")!,
            JsonValue.Create("Ready")!,
            JsonValue.Create("READY")!,
        ];

        var result = values.ComputeEnum(
            "Status",
            string.Empty,
            DefaultSettings.ToEnumNamingSettings());

        result.Values.Select(static value => value.Name)
            .Should().Equal("Ready", "Ready2", "Ready3");
    }
    [TestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public void MixedAsyncApiEvents_RejectForeignSingletonStrings(JsonSerializerType serializer)
    {
        const string json = """
        {
          "asyncapi":"3.0.0", "info":{"title":"Mixed events","version":"1"},
          "channels":{"events":{"address":"/events","messages":{
            "Alpha":{"$ref":"#/components/messages/Alpha"},
            "Beta":{"$ref":"#/components/messages/Beta"},
            "Audio":{"$ref":"#/components/messages/Audio"}}}},
          "operations":{"receive":{"action":"receive","channel":{"$ref":"#/channels/events"},
            "messages":[{"$ref":"#/channels/events/messages/Alpha"},
              {"$ref":"#/channels/events/messages/Beta"},{"$ref":"#/channels/events/messages/Audio"}]}},
          "components":{"messages":{
            "Alpha":{"payload":{"$ref":"#/components/schemas/Alpha"}},
            "Beta":{"payload":{"$ref":"#/components/schemas/Beta"}},
            "Audio":{"payload":{"$ref":"#/components/schemas/Audio"}}},
            "schemas":{
              "Alpha":{"type":"object","required":["type"],"properties":{
                "type":{"type":"string","enum":["alpha"]}}},
              "Beta":{"type":"object","required":["type"],"properties":{
                "type":{"type":"string","enum":["beta"]}}},
              "Audio":{"type":"string","format":"binary"},
              "Status":{"type":"string","enum":["ready","done"]},
              "OpenStatus":{"type":"string","enum":["known"],"x-speakeasy-unknown-values":true}
            }}
        }
        """;
        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            TargetFramework = "net8.0",
            JsonSerializerType = serializer,
        };
        var data = AsyncApiData.Prepare(((json, settings), GlobalSettings: settings));
        var closedSingletons = data.Enums.Where(model => model.EnumValues.Length == 1 && !model.IsOpenEnum).ToArray();

        data.AnyOfs.Single(union => union.Name == "ServerEvent").DiscriminatorPropertyName.Should().BeNullOrEmpty();
        closedSingletons.Should().HaveCount(2);
        foreach (var model in closedSingletons)
        {
            model.RejectUnknownStringValues.Should().BeTrue();
            Sources.GenerateEnumJsonConverter(model).Should().Contain(serializer == JsonSerializerType.SystemTextJson
                ? "throw new global::System.Text.Json.JsonException"
                : "throw new global::Newtonsoft.Json.JsonSerializationException");
        }
        data.Enums.Single(model => model.ClassName == "Status").RejectUnknownStringValues.Should().BeFalse();
        data.Enums.Single(model => model.ClassName == "OpenStatus").RejectUnknownStringValues.Should().BeFalse();
    }

}
