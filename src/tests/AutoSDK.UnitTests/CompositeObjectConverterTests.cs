using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class CompositeObjectConverterTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net10.0",
        Namespace = "G",
        ClassName = "Api",
        JsonSerializerType = JsonSerializerType.SystemTextJson,
        GenerateJsonSerializerContextTypes = true,
        GenerateSdk = true,
        GenerateModels = true,
        GenerateMethods = true,
    };

    [TestMethod]
    public void SystemTextJson_ObjectAnyOfAndAllOfConverters_UseNullableTypeInfoForWritePath()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: composite
                              version: 1.0.0
                            paths:
                              /payload:
                                post:
                                  operationId: createPayload
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/Payload'
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/Payload'
                            components:
                              schemas:
                                ObjectA:
                                  type: object
                                  properties:
                                    a:
                                      type: string
                                ObjectB:
                                  type: object
                                  properties:
                                    b:
                                      type: string
                                AllOfA:
                                  type: object
                                  properties:
                                    id:
                                      type: string
                                AllOfB:
                                  type: object
                                  properties:
                                    meta:
                                      type: string
                                Payload:
                                  type: object
                                  properties:
                                    choice:
                                      anyOf:
                                        - $ref: '#/components/schemas/ObjectA'
                                        - $ref: '#/components/schemas/ObjectB'
                                    merged:
                                      allOf:
                                        - $ref: '#/components/schemas/AllOfA'
                                        - $ref: '#/components/schemas/AllOfB'
                            """;

        var data = global::AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var anyOf = data.AnyOfs.Single(x => x.SubType == "AnyOf" && !x.IsNamed && x.Count == 2);
        var allOf = data.AnyOfs.Single(x => x.SubType == "AllOf" && !x.IsNamed && x.Count == 2);

        var generatedAnyOf = Sources.GenerateAnyOfJsonConverter(anyOf);
        var generatedAllOf = Sources.GenerateAnyOfJsonConverter(allOf);

        generatedAnyOf.Should().Contain("JsonTypeInfo<T1?>");
        generatedAnyOf.Should().Contain("JsonTypeInfo<T2?>");
        generatedAnyOf.Should().Contain("JsonSerializer.Serialize(writer, value.Value1, typeInfo);");
        generatedAnyOf.Should().Contain("JsonSerializer.Serialize(writer, value.Value2, typeInfo);");

        generatedAllOf.Should().Contain("JsonTypeInfo<T1?>");
        generatedAllOf.Should().Contain("JsonTypeInfo<T2?>");
        generatedAllOf.Should().Contain("JsonSerializer.Serialize(writer, value.Value1, typeInfo);");
        generatedAllOf.Should().Contain("JsonSerializer.Serialize(writer, value.Value2, typeInfo);");
    }
}
