using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class OpenApiOverridesTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net8.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateModels = true,
        GenerateSdk = true,
    };

    [TestMethod]
    public void ObjectOverride_ReplacesReferencedSchemaTypeWithObject()
    {
        var settings = DefaultSettings with
        {
            OpenApiOverrides =
            [
                "#/components/schemas/Tool/properties/input_schema=object",
            ],
        };

        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: test
                              version: 1.0.0
                            paths:
                              /tools:
                                post:
                                  operationId: createTool
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/Tool'
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              schemas:
                                InputSchema:
                                  type: object
                                  properties:
                                    kind:
                                      type: string
                                Tool:
                                  type: object
                                  required:
                                    - input_schema
                                  properties:
                                    input_schema:
                                      $ref: '#/components/schemas/InputSchema'
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var generatedModel = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));

        generatedModel.Should().Contain("public required object InputSchema { get; set; }");
        generatedModel.Should().NotContain("public required global::G.InputSchema InputSchema { get; set; }");
    }

    [TestMethod]
    public void DictionaryOverride_ReplacesReferencedSchemaTypeWithDictionary()
    {
        var settings = DefaultSettings with
        {
            OpenApiOverrides =
            [
                "#/components/schemas/Tool/properties/input_schema=dictionary",
            ],
        };

        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: test
                              version: 1.0.0
                            paths:
                              /tools:
                                post:
                                  operationId: createTool
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/Tool'
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              schemas:
                                InputSchema:
                                  type: object
                                  properties:
                                    kind:
                                      type: string
                                Tool:
                                  type: object
                                  required:
                                    - input_schema
                                  properties:
                                    input_schema:
                                      $ref: '#/components/schemas/InputSchema'
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var generatedModel = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));

        generatedModel.Should().Contain("public required global::System.Collections.Generic.Dictionary<string, object> InputSchema { get; set; }");
    }

    [TestMethod]
    public void RemoveOverride_DropsPropertyAndRequiredMarker()
    {
        var settings = DefaultSettings with
        {
            OpenApiOverrides =
            [
                "#/components/schemas/HTTPToolFunctionParameters/properties/additionalProperties=remove",
            ],
        };

        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: test
                              version: 1.0.0
                            paths:
                              /tools:
                                post:
                                  operationId: createTool
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/HTTPToolFunctionParameters'
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              schemas:
                                HTTPToolFunctionParamProperties:
                                  type: object
                                HTTPToolFunctionParameters:
                                  type: object
                                  required:
                                    - properties
                                    - required
                                    - additionalProperties
                                  properties:
                                    properties:
                                      type: object
                                      additionalProperties:
                                        $ref: '#/components/schemas/HTTPToolFunctionParamProperties'
                                    required:
                                      type: array
                                      items:
                                        type: string
                                    additionalProperties:
                                      type: boolean
                            """;

        var document = yaml.GetOpenApiDocument(settings);
        var schema = (Microsoft.OpenApi.OpenApiSchema)document.Components!.Schemas!["HTTPToolFunctionParameters"];
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var generatedModel = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));

        schema.Properties!.Should().NotContainKey("additionalProperties");
        schema.Required.Should().NotContain("additionalProperties");
        generatedModel.Should().NotContain("public bool? AdditionalProperties { get; set; }");
        generatedModel.Should().NotContain("AdditionalProperties2");
        generatedModel.Should().Contain("public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; }");
    }
}
