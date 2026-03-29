using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class ObsoleteSelfReferenceTests
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
    public void ModelReferencingDeprecatedGeneratedType_SuppressesCS0618InGeneratedFile()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: obsolete-self-ref
                              version: 1.0.0
                            paths:
                              /messages:
                                post:
                                  operationId: createMessage
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/Container'
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/Container'
                            components:
                              schemas:
                                DeprecatedType:
                                  type: object
                                  deprecated: true
                                  properties:
                                    value:
                                      type: string
                                Container:
                                  type: object
                                  properties:
                                    old:
                                      $ref: '#/components/schemas/DeprecatedType'
                            """;

        var data = global::AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var container = data.Classes.Single(x => x.ClassName == "Container");
        var generatedModel = Sources.GenerateModel(container);

        generatedModel.Should().Contain("#pragma warning disable CS0618 // Type or member is obsolete");
        generatedModel.Should().Contain("public global::G.DeprecatedType? Old { get; set; }");
        generatedModel.Should().Contain("[global::System.Obsolete(\"This property marked as deprecated.\")]");
    }
}
