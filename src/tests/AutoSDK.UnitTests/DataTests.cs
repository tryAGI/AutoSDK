using AutoSDK.Generation;
using AutoSDK.Naming.Methods;
using AutoSDK.Naming.Models;
using AutoSDK.Serialization.Json;
using ExcludedModelNamespaceMode = AutoSDK.Models.ExcludedModelNamespaceMode;
using SchemaNamingSettings = AutoSDK.Models.SchemaNamingSettings;

namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [TestMethod]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    [DataRow(JsonSerializerType.SystemTextJson)]
    public void PrimitiveConstValues_AreEmittedAsTypedLiterals(JsonSerializerType jsonSerializerType)
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = jsonSerializerType,
            TargetFramework = jsonSerializerType is JsonSerializerType.SystemTextJson
                ? "net8.0"
                : "net6.0",
        };
        const string json = """
                            {
                              "openapi": "3.1.0",
                              "info": { "title": "t", "version": "1" },
                              "paths": {
                                "/x": {
                                  "post": {
                                    "operationId": "createX",
                                    "requestBody": {
                                      "required": true,
                                      "content": {
                                        "application/json": {
                                          "schema": {
                                            "type": "object",
                                            "properties": {
                                              "n": { "type": "number", "const": 8 },
                                              "i": { "type": "integer", "const": 3 },
                                              "b": { "type": "boolean", "const": true },
                                              "s": { "type": "string", "const": "x" }
                                            },
                                            "required": ["n", "i", "b", "s"]
                                          }
                                        }
                                      }
                                    },
                                    "responses": {
                                      "200": { "description": "ok" }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var data = Data.Prepare(((json, settings), GlobalSettings: settings));
        var generatedModel = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));
        var generatedMethod = string.Join("\n\n", data.Methods.Select(x => Sources.GenerateEndPoint(x)));

        generatedModel.Should().Contain("public double N { get; set; } = 8;");
        generatedModel.Should().Contain("public int I { get; set; } = 3;");
        generatedModel.Should().Contain("public bool B { get; set; } = true;");
        generatedModel.Should().Contain("public string S { get; set; } = \"x\";");
        generatedMethod.Should().Contain("double n = 8,");
        generatedMethod.Should().Contain("int i = 3,");
        generatedMethod.Should().Contain("bool b = true,");
        generatedMethod.Should().Contain("string s = \"x\",");
        generatedModel.Should().NotContain("= \"8\";");
        generatedModel.Should().NotContain("= \"3\";");
        generatedModel.Should().NotContain("= \"True\";");
        generatedMethod.Should().NotContain("double n = \"8\"");
        generatedMethod.Should().NotContain("int i = \"3\"");
        generatedMethod.Should().NotContain("bool b = \"True\"");
    }

    [TestMethod]
    public void ConvenienceOverload_IncludesRequiredNullableAnyOfRequestProperty()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            TargetFramework = "net8.0",
        };
        const string yaml = """
                            openapi: 3.1.0
                            info:
                              title: portkey-repro
                              version: 1.0.0
                            paths:
                              /prompts/{promptId}/completions:
                                post:
                                  operationId: createPromptCompletion
                                  parameters:
                                    - in: path
                                      name: promptId
                                      required: true
                                      schema:
                                        type: string
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/CreatePromptCompletionRequest'
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              schemas:
                                CreatePromptCompletionRequest:
                                  type: object
                                  required:
                                    - variables
                                  properties:
                                    variables:
                                      anyOf:
                                        - type: object
                                          additionalProperties: {}
                                        - type: 'null'
                                    stream:
                                      type: boolean
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var generatedModel = string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));
        var generatedMethod = string.Join("\n\n", data.Methods.Select(x => Sources.GenerateEndPoint(x)));

        generatedModel.Should().Contain("public object? Variables { get; set; }");
        generatedModel.Should().NotContain("public required object? Variables { get; set; }");
        generatedMethod.Should().Contain("object? variables");
        generatedMethod.Should().Contain("Variables = variables,");
    }

    [TestMethod]
    public void ExcludeDeprecatedOperations_UsesFernAvailability()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GenerateModels = true,
            ExcludeDeprecatedOperations = true,
            MethodNamingConvention = MethodNamingConvention.Summary,
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /old:
                                get:
                                  summary: Old endpoint
                                  x-fern-availability: deprecated
                                  responses:
                                    '200':
                                      description: OK
                              /new:
                                get:
                                  summary: New endpoint
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].MethodName.Should().Be("NewEndpointAsync");
    }

    [TestMethod]
    public void IgnoreOpenApiErrors_SkipsUnresolvedNestedReferences()
    {
        var settings = DefaultSettings with
        {
            IgnoreOpenApiErrors = true,
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /items:
                                get:
                                  operationId: getItems
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            properties:
                                              item:
                                                type: object
                                                properties:
                                                  broken:
                                                    $ref: '#/components/schemas/MissingType'
                            components:
                              schemas:
                                ExistingType:
                                  type: object
                                  properties:
                                    id:
                                      type: string
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().ContainSingle();
        EnumerateContexts(data.FilteredSchemas)
            .Should()
            .NotContain(x => x.ReferenceId == "MissingType");

        static IEnumerable<AutoSDK.Models.SchemaContext> EnumerateContexts(IEnumerable<AutoSDK.Models.SchemaContext> contexts)
        {
            foreach (var context in contexts)
            {
                yield return context;

                foreach (var child in EnumerateContexts(context.Children))
                {
                    yield return child;
                }
            }
        }
    }

    [TestMethod]
    public void ExcludeDeprecatedOperations_DiscriminatorDerivedModels_GenerateWithoutSchemaContext()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GenerateModels = true,
            ExcludeDeprecatedOperations = true,
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: DerivedInheritanceRegression
                              version: 1.0.0
                            paths:
                              /animals:
                                get:
                                  deprecated: true
                                  operationId: listAnimals
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/Cat'
                              /cats:
                                post:
                                  operationId: createCat
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/Cat'
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/Cat'
                            components:
                              schemas:
                                Animal:
                                  type: object
                                  discriminator:
                                    propertyName: kind
                                    mapping:
                                      cat: '#/components/schemas/Cat'
                                  properties:
                                    kind:
                                      type: string
                                Cat:
                                  allOf:
                                    - $ref: '#/components/schemas/Animal'
                                    - type: object
                                      properties:
                                        name:
                                          type: string
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var action = () => string.Join("\n\n", data.Classes.Select(x => Sources.GenerateModel(x)));

        action.Should().NotThrow();
        action().Should().Contain("public sealed partial class Cat : global::G.Animal");
    }

    [TestMethod]
    public void ObjectMemberPropertyNames_AreRenamedInsteadOfUsingNewModifier()
    {
        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: ObjectMemberProperties
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                CollisionModel:
                                  type: object
                                  properties:
                                    equals:
                                      type: boolean
                                    toString:
                                      type: string
                                    getHashCode:
                                      type: integer
                                    getType:
                                      type: string
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var model = data.Classes.Single(x => x.ClassName == "CollisionModel");
        var generated = Sources.GenerateModel(model);

        model.Properties.Select(x => x.Name).Should().Contain("EqualsValue");
        model.Properties.Select(x => x.Name).Should().Contain("ToStringValue");
        model.Properties.Select(x => x.Name).Should().Contain("GetHashCodeValue");
        model.Properties.Select(x => x.Name).Should().Contain("GetTypeValue");
        generated.Should().Contain("public bool? EqualsValue");
        generated.Should().Contain("public string? ToStringValue");
        generated.Should().Contain("public int? GetHashCodeValue");
        generated.Should().Contain("public string? GetTypeValue");
        generated.Should().NotContain("public new bool? Equals");
        generated.Should().NotContain("public new string? ToString");
        generated.Should().NotContain("public new int? GetHashCode");
        generated.Should().NotContain("public new string? GetType");
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void ExcludeModels_RemovesReferencedComponentModels(bool useLegacyPrepare)
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GenerateModels = true,
            ExcludeModels = ["Pet"],
        };

        var data = PreparePetstoreWithExclusions(useLegacyPrepare, new H.Resource("petstore.yaml").AsString(), settings);

        data.Classes.Select(x => x.ClassName).Should().NotContain("Pet");
        data.Classes.Select(x => x.ClassName).Should().Contain("Error");
        data.Methods.First(x => x.MethodName == "GetPetsByPetIdAsync")
            .SuccessResponse.Type.CSharpTypeWithNullabilityForValueTypes
            .Should().Be("global::TestNamespace.Pet");
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void ExcludeModels_RemovesReferencedComponentModels_WithDotsInComponentId(bool useLegacyPrepare)
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GenerateModels = true,
            ExcludeModels = ["PetStore.Pet"],
        };
        var yaml = new H.Resource("petstore.yaml").AsString()
            .Replace("#/components/schemas/Pet\"", "#/components/schemas/PetStore.Pet\"")
            .Replace("\n    Pet:\n", "\n    PetStore.Pet:\n");

        var data = PreparePetstoreWithExclusions(useLegacyPrepare, yaml, settings);

        data.Classes.Select(x => x.ClassName).Should().NotContain("PetStorePet");
        data.Classes.Select(x => x.ClassName).Should().Contain("Error");
        data.Methods.First(x => x.MethodName == "GetPetsByPetIdAsync")
            .SuccessResponse.Type.CSharpTypeWithNullabilityForValueTypes
            .Should().Be("global::TestNamespace.PetStorePet");
    }

    [TestMethod]
    [DataRow("PetStore.Pet", "Pet", "PetStore", "G.PetStore", "PetStore.Pet")]
    [DataRow("System.Text.Json.Nodes.JsonObject", "JsonObject", "System.Text.Json.Nodes", "G.System.Text.Json.Nodes", "System.Text.Json.Nodes.JsonObject")]
    [DataRow("PetStore..Pet", "Pet", "PetStore", "G.PetStore", "PetStore.Pet")]
    public void NamespaceDelimiter_TryResolve_ParsesExpectedSegments(
        string rawId,
        string expectedClassName,
        string expectedNamespaceSuffix,
        string expectedGeneratedNamespace,
        string expectedExternalQualifiedName)
    {
        var resolved = CSharpNamespacedTypeNameResolver.TryResolve(
            rawId,
            new SchemaNamingSettings(string.Empty, useExtensionNaming: true, namespaceDelimiter: "."),
            rootNamespace: "G",
            out var value);

        resolved.Should().BeTrue();
        value.Should().NotBeNull();
        value!.ClassName.Should().Be(expectedClassName);
        value.NamespaceSuffix.Should().Be(expectedNamespaceSuffix);
        value.GeneratedNamespace.Should().Be(expectedGeneratedNamespace);
        value.GeneratedQualifiedName.Should().Be($"{expectedGeneratedNamespace}.{expectedClassName}");
        value.ExternalQualifiedName.Should().Be(expectedExternalQualifiedName);
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void NamespaceDelimiter_GeneratesNestedNamespaceForDottedComponentId(bool useLegacyPrepare)
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GenerateModels = true,
            NamespaceDelimiter = ".",
        };
        var yaml = new H.Resource("petstore.yaml").AsString()
            .Replace("#/components/schemas/Pet\"", "#/components/schemas/PetStore.Pet\"")
            .Replace("\n    Pet:\n", "\n    PetStore.Pet:\n");

        var data = PrepareOpenApi(useLegacyPrepare, yaml, settings);
        var pet = data.Classes.Single(x => x.GlobalClassName == "global::TestNamespace.PetStore.Pet");

        pet.ClassName.Should().Be("Pet");
        pet.Namespace.Should().Be("TestNamespace.PetStore");
        pet.FileNameWithoutExtension.Should().Be("TestNamespace.PetStore.Models.Pet");
        Sources.GenerateModel(pet).Should().Contain("namespace TestNamespace.PetStore");
        data.Methods.First(x => x.MethodName == "GetPetsByPetIdAsync")
            .SuccessResponse.Type.CSharpTypeWithNullabilityForValueTypes
            .Should().Be("global::TestNamespace.PetStore.Pet");
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void ExcludeModels_RemovesReferencedComponentModels_WithNamespaceDelimiter_ExternalMode(bool useLegacyPrepare)
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GenerateModels = true,
            ExcludeModels = ["PetStore.Pet"],
            NamespaceDelimiter = ".",
        };
        var yaml = new H.Resource("petstore.yaml").AsString()
            .Replace("#/components/schemas/Pet\"", "#/components/schemas/PetStore.Pet\"")
            .Replace("\n    Pet:\n", "\n    PetStore.Pet:\n");

        var data = PrepareOpenApi(useLegacyPrepare, yaml, settings);

        data.Classes.Select(x => x.GlobalClassName).Should().NotContain("global::TestNamespace.PetStore.Pet");
        data.Methods.First(x => x.MethodName == "GetPetsByPetIdAsync")
            .SuccessResponse.Type.CSharpTypeWithNullabilityForValueTypes
            .Should().Be("global::PetStore.Pet");
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void ExcludeModels_RemovesReferencedComponentModels_WithNamespaceDelimiter_SdkRootMode(bool useLegacyPrepare)
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GenerateModels = true,
            ExcludeModels = ["PetStore.Pet"],
            NamespaceDelimiter = ".",
            ExcludedModelNamespaceMode = ExcludedModelNamespaceMode.SdkRoot,
        };
        var yaml = new H.Resource("petstore.yaml").AsString()
            .Replace("#/components/schemas/Pet\"", "#/components/schemas/PetStore.Pet\"")
            .Replace("\n    Pet:\n", "\n    PetStore.Pet:\n");

        var data = PrepareOpenApi(useLegacyPrepare, yaml, settings);

        data.Classes.Select(x => x.GlobalClassName).Should().NotContain("global::TestNamespace.PetStore.Pet");
        data.Methods.First(x => x.MethodName == "GetPetsByPetIdAsync")
            .SuccessResponse.Type.CSharpTypeWithNullabilityForValueTypes
            .Should().Be("global::TestNamespace.PetStore.Pet");
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void NamespaceDelimiter_ResolvesCollisionsPerQualifiedNamespace(bool useLegacyPrepare)
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GenerateModels = true,
            NamespaceDelimiter = ".",
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: NamespaceCollision
                              version: 1.0.0
                            paths:
                              /foo-user:
                                get:
                                  operationId: getFooUser
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/Foo.User'
                              /bar-user:
                                get:
                                  operationId: getBarUser
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/Bar.User'
                            components:
                              schemas:
                                Foo.User:
                                  type: object
                                  properties:
                                    id:
                                      type: string
                                Bar.User:
                                  type: object
                                  properties:
                                    id:
                                      type: string
                            """;

        var data = PrepareOpenApi(useLegacyPrepare, yaml, settings);
        var users = data.Classes
            .Where(x => x.ClassName == "User")
            .OrderBy(x => x.Namespace, StringComparer.Ordinal)
            .ToArray();

        users.Should().HaveCount(2);
        users.Select(x => x.Namespace).Should().Equal("TestNamespace.Bar", "TestNamespace.Foo");
        users.Select(x => x.GlobalClassName).Should().Equal("global::TestNamespace.Bar.User", "global::TestNamespace.Foo.User");
        data.Methods.First(x => x.MethodName == "GetBarUserAsync")
            .SuccessResponse.Type.CSharpTypeWithNullabilityForValueTypes
            .Should().Be("global::TestNamespace.Bar.User");
        data.Methods.First(x => x.MethodName == "GetFooUserAsync")
            .SuccessResponse.Type.CSharpTypeWithNullabilityForValueTypes
            .Should().Be("global::TestNamespace.Foo.User");
    }

    [TestMethod]
    public void DiscriminatorOnlyOneOfWrapper_DoesNotExposeHiddenDiscriminatorToConvenienceOverload()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            TargetFramework = "net8.0",
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: repro
                              version: 1.0.0
                            paths:
                              /items:
                                post:
                                  operationId: createItem
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/CreateItemRequest'
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/OkResponse'
                            components:
                              schemas:
                                OkResponse:
                                  type: object
                                  properties:
                                    ok:
                                      type: boolean
                                CreateTextRequest:
                                  type: object
                                  required:
                                    - type
                                    - text
                                  properties:
                                    type:
                                      type: string
                                      default: text
                                    text:
                                      type: string
                                CreateNumberRequest:
                                  type: object
                                  required:
                                    - type
                                    - number
                                  properties:
                                    type:
                                      type: string
                                      default: number
                                    number:
                                      type: integer
                                CreateItemRequest:
                                  required:
                                    - type
                                  properties:
                                    type:
                                      type: string
                                      default: text
                                  discriminator:
                                    propertyName: type
                                    mapping:
                                      text: '#/components/schemas/CreateTextRequest'
                                      number: '#/components/schemas/CreateNumberRequest'
                                  oneOf:
                                    - $ref: '#/components/schemas/CreateTextRequest'
                                    - $ref: '#/components/schemas/CreateNumberRequest'
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var requestModel = data.Classes.Single(x => x.ClassName == "CreateItemRequest");
        var endPoint = data.Methods.Should().ContainSingle().Subject;
        var generatedEndPoint = Sources.GenerateEndPoint(endPoint);

        requestModel.IsBaseClass.Should().BeTrue();
        requestModel.Properties.Should().BeEmpty();
        endPoint.Parameters.Where(x => x.Location == null).Should().BeEmpty();
        endPoint.RequestType.CSharpTypeWithoutNullability.Should().Be("global::G.CreateItemRequest");
        generatedEndPoint.Should().NotContain("Type = type");
        generatedEndPoint.Should().NotContain(" string type,");
        generatedEndPoint.Should().Contain("global::G.CreateItemRequest request");
        generatedEndPoint.Should().NotContain("object request");
    }

    [TestMethod]
    public void Issue161_DiscriminatorBasedRequestBody_DoesNotGenerateNonCompilingOverload()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            TargetFramework = "net8.0",
        };
        const string yaml = """
                            openapi: 3.0.0
                            info:
                              title: Repro
                              version: 1.0.0
                            paths:
                              /pets:
                                post:
                                  operationId: createPet
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/PetRequest'
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            type: string
                            components:
                              schemas:
                                PetRequest:
                                  type: object
                                  properties:
                                    type:
                                      type: string
                                      default: cat
                                  discriminator:
                                    propertyName: type
                                    mapping:
                                      cat: '#/components/schemas/CatRequest'
                                      dog: '#/components/schemas/DogRequest'
                                  oneOf:
                                    - $ref: '#/components/schemas/CatRequest'
                                    - $ref: '#/components/schemas/DogRequest'
                                CatRequest:
                                  type: object
                                  properties:
                                    type:
                                      type: string
                                      default: cat
                                    name:
                                      type: string
                                  required: [name]
                                DogRequest:
                                  type: object
                                  properties:
                                    type:
                                      type: string
                                      default: dog
                                    bark:
                                      type: boolean
                                  required: [bark]
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var requestModel = data.Classes.Single(x => x.ClassName == "PetRequest");
        var endPoint = data.Methods.Should().ContainSingle().Subject;
        var generatedEndPoint = Sources.GenerateEndPoint(endPoint);

        // PetRequest is a discriminator base class with empty visible properties
        requestModel.IsBaseClass.Should().BeTrue();
        requestModel.Properties.Should().BeEmpty();

        // The primary method should accept typed PetRequest parameter
        endPoint.RequestType.CSharpTypeWithoutNullability.Should().Be("global::G.PetRequest");
        generatedEndPoint.Should().Contain("global::G.PetRequest request");

        // No convenience overload that would reference the non-existent Type property
        generatedEndPoint.Should().NotContain("Type = type");
        generatedEndPoint.Should().NotContain(" string type,");
        generatedEndPoint.Should().NotContain("string? type");
    }

    [TestMethod]
    public void NonDiscriminator_EmptyBodyParams_StillGeneratesConvenienceOverload()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            TargetFramework = "net8.0",
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: test
                              version: 1.0.0
                            paths:
                              /ping:
                                post:
                                  operationId: sendPing
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/PingRequest'
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              schemas:
                                PingRequest:
                                  type: object
                                  properties:
                                    version:
                                      type: string
                                      const: "1.0"
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var requestModel = data.Classes.Single(x => x.ClassName == "PingRequest");
        var endPoint = data.Methods.Should().ContainSingle().Subject;
        var generatedEndPoint = Sources.GenerateEndPoint(endPoint);

        // Not a base class — regular type with all-const properties
        requestModel.IsBaseClass.Should().BeFalse();

        // Convenience overload should still be generated (constructs PingRequest for caller)
        generatedEndPoint.Should().Contain("new global::G.PingRequest");
    }

    [TestMethod]
    public void SharedBaseDiscriminatorOneOfWrapper_PreservesNamedRequestUnion()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            TargetFramework = "net8.0",
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: repro
                              version: 1.0.0
                            paths:
                              /agent-input:
                                post:
                                  operationId: createAgentInput
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/CreateInputRequest'
                                  responses:
                                    '200':
                                      description: ok
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/AgentResponse'
                            components:
                              schemas:
                                AgentResponse:
                                  type: object
                                  properties:
                                    ok:
                                      type: boolean
                                AgentInput:
                                  type: object
                                  properties:
                                    text:
                                      type: string
                                InputBehavior:
                                  type: string
                                  enum:
                                    - append
                                    - replace
                                CreateInputRequestBase:
                                  type: object
                                  properties:
                                    stream_response:
                                      type: boolean
                                      default: false
                                CreateInputMessageRequest:
                                  allOf:
                                    - $ref: '#/components/schemas/CreateInputRequestBase'
                                    - required:
                                        - messages
                                      type: object
                                      properties:
                                        type:
                                          type: string
                                          default: input_message
                                        messages:
                                          type: array
                                          items:
                                            $ref: '#/components/schemas/AgentInput'
                                        since:
                                          type: string
                                        behavior:
                                          $ref: '#/components/schemas/InputBehavior'
                                CreateInterruptRequest:
                                  allOf:
                                    - $ref: '#/components/schemas/CreateInputRequestBase'
                                    - required:
                                        - type
                                      type: object
                                      properties:
                                        type:
                                          type: string
                                          default: interrupt
                                CreateCompactRequest:
                                  allOf:
                                    - $ref: '#/components/schemas/CreateInputRequestBase'
                                    - required:
                                        - type
                                      type: object
                                      properties:
                                        type:
                                          type: string
                                          default: compact
                                        compact_up_to_event_id:
                                          type: string
                                        compaction_message:
                                          type: string
                                CreateInputRequest:
                                  properties:
                                    type:
                                      type: string
                                      default: input_message
                                  description: A request to create input for an agent session.
                                  x-vectara-base-schema: '#/CreateInputRequestBase'
                                  discriminator:
                                    propertyName: type
                                    mapping:
                                      input_message: '#/components/schemas/CreateInputMessageRequest'
                                      interrupt: '#/components/schemas/CreateInterruptRequest'
                                      compact: '#/components/schemas/CreateCompactRequest'
                                  oneOf:
                                    - $ref: '#/components/schemas/CreateInputMessageRequest'
                                    - $ref: '#/components/schemas/CreateInterruptRequest'
                                    - $ref: '#/components/schemas/CreateCompactRequest'
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var anyOf = data.AnyOfs.Single(x => x.Name == "CreateInputRequest");
        var endPoint = data.Methods.Should().ContainSingle().Subject;
        var generatedAnyOf = Sources.GenerateAnyOf(anyOf);
        var generatedEndPoint = Sources.GenerateEndPoint(endPoint);

        data.Classes.Should().NotContain(x => x.ClassName == "CreateInputRequest");
        anyOf.SubType.Should().Be("OneOf");
        anyOf.Properties.Select(x => x.Name).Should().Contain(["InputMessage", "Interrupt", "Compact"]);
        generatedAnyOf.Should().Contain("public readonly partial struct CreateInputRequest");
        endPoint.RequestType.CSharpTypeWithoutNullability.Should().Be("global::G.CreateInputRequest");
        generatedEndPoint.Should().Contain("global::G.CreateInputRequest request");
        generatedEndPoint.Should().NotContain("object request");
    }

    [TestMethod]
    public void VectaraOfficialSpec_CreateInputRequest_PreservesNamedRequestUnion()
    {
        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateModels = true,
            GenerateSdk = true,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            TargetFramework = "net8.0",
            UseExtensionNaming = false,
        };

        var data = Data.Prepare(((new H.Resource("vectara.yaml").AsString(), settings), GlobalSettings: settings));
        var anyOf = data.AnyOfs.Single(x => x.Name == "CreateInputRequest");
        var endPoint = data.Methods.Single(x => x.MethodName == "CreateAgentInputAsync");
        var generatedEndPoint = Sources.GenerateEndPoint(endPoint);

        data.Classes.Should().NotContain(x => x.ClassName == "CreateInputRequest");
        anyOf.SubType.Should().Be("OneOf");
        anyOf.Properties.Select(x => x.Name).Should().Contain(["InputMessage", "Interrupt", "Compact"]);
        endPoint.RequestType.CSharpTypeWithoutNullability.Should().Be("global::G.CreateInputRequest");
        generatedEndPoint.Should().Contain("global::G.CreateInputRequest request");
        generatedEndPoint.Should().NotContain("object request");
    }

    [TestMethod]
    public void AllOf_WithOptionalComponent_DoesNotRequireEveryValue()
    {
        var settings = DefaultSettings with
        {
            GenerateModels = true,
        };
        const string yaml = """
                            openapi: 3.1.0
                            info:
                              title: Test
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
                                          allOf:
                                            - type: object
                                              required:
                                                - url
                                              properties:
                                                url:
                                                  type: string
                                            - $ref: '#/components/schemas/ScrapeOptions'
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              schemas:
                                ScrapeOptions:
                                  type: object
                                  properties:
                                    formats:
                                      type: array
                                      items:
                                        type: string
                                    onlyMainContent:
                                      type: boolean
                            """;

        var data = Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var allOf = data.AnyOfs.Single(x => x.SubType == "AllOf" && !x.IsNamed && x.Count == 2);
        var generatedAllOf = Sources.GenerateAnyOf(allOf);

        generatedAllOf.Should().Contain("private static bool RequiresValue<TValue>() => RequirementCache<TValue>.Value;");
        generatedAllOf.Should().Contain("return (!RequiresValue<T1>() || IsValue1) && (!RequiresValue<T2>() || IsValue2);");
        generatedAllOf.Should().NotContain("return IsValue1 && IsValue2;");
    }

    [TestMethod]
    [DataRow("ai21.json")]
    [DataRow("anthropic.yaml")]
    [DataRow("assemblyai.yaml")]
    [DataRow("cohere.yaml")]
    [DataRow("dedoose.json")]
    [DataRow("github.yaml")]
    [DataRow("huggingface.yaml")]
    [DataRow("ipinfo.yaml")]
    [DataRow("langsmith.json")]
    [DataRow("leonardo.yaml")]
    [DataRow("ollama.yaml")]
    [DataRow("openai.yaml")]
    [DataRow("petstore.yaml")]
    [DataRow("replicate.json")]
    [DataRow("special-cases.yaml")]
    [DataRow("together.yaml")]
    [DataRow("mystic.yaml")]
    [DataRow("twitch.json")]
    [DataRow("heygen.yaml")]
    [DataRow("instill.yaml")]
    [DataRow("ideogram.yaml")]
    [DataRow("google-gemini.yaml")]
    [DataRow("vectara.yaml")]
    [DataRow("mistral.yaml")]
    [DataRow("weaviate.yaml")]
    [DataRow("elevenlabs.json")]
    [DataRow("jina.json")]
    [DataRow("recraft.yaml")]
    [DataRow("luma.yaml")]
    [DataRow("ultravox.yaml")]
    [DataRow("deepinfra.json")]
    public Task PrepareData(string resourceName)
    {
        var settings = DefaultSettings with
        {
            GenerateJsonSerializerContextTypes = true,
            MethodNamingConvention = resourceName switch
            {
                "mystic.yaml" => MethodNamingConvention.Summary,
                "replicate.json" => MethodNamingConvention.OperationIdWithDots,
                _ => default,
            },
            IgnoreOpenApiErrors = resourceName switch
            {
                "langsmith.json" => true,
                "elevenlabs.json" => true,
                "ai21.json" => true,
                "replicate.json" => true,
                "luma.yaml" => true,
                "openai.yaml" => true,
                "deepinfra.json" => true,
                "cohere.yaml" => true,
                // Microsoft.OpenApi 3.x parsing issues - sentinel values, 'any' type, schema format
                "anthropic.yaml" => true,
                "assemblyai.yaml" => true,
                "github.yaml" => true,
                "huggingface.yaml" => true,
                "ipinfo.yaml" => true,
                "leonardo.yaml" => true,
                "ollama.yaml" => true,
                "petstore.yaml" => true,
                "special-cases.yaml" => true,
                "together.yaml" => true,
                "mystic.yaml" => true,
                "twitch.json" => true,
                "heygen.yaml" => true,
                "instill.yaml" => true,
                "ideogram.yaml" => true,
                "google-gemini.yaml" => true,
                "vectara.yaml" => true,
                "mistral.yaml" => true,
                "weaviate.yaml" => true,
                "jina.json" => true,
                "recraft.yaml" => true,
                "ultravox.yaml" => true,
                "dedoose.json" => true,
                _ => false,
            },
        };
        return VerifyAsync(
            data: Data.Prepare(((new H.Resource(resourceName).AsString(), settings), GlobalSettings: settings)),
            resourceName: Path.GetFileNameWithoutExtension(resourceName));
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void PrepareCohereFernStreamingSpec_SplitsChatEndpoints(bool useLegacyPrepare)
    {
        var settings = DefaultSettings with
        {
            IgnoreOpenApiErrors = true,
        };
        var yaml = new H.Resource("cohere.yaml").AsString();
        var data = useLegacyPrepare
            ? Data.Prepare(((yaml, settings), GlobalSettings: settings))
            : CSharpPipeline.PrepareAndEnrich(((yaml, settings), GlobalSettings: settings));

        data.Methods.Count(x => string.Equals(x.Path, "\"/v1/chat\"", StringComparison.Ordinal)).Should().Be(2);
        data.Methods.Count(x => string.Equals(x.Path, "\"/v2/chat\"", StringComparison.Ordinal)).Should().Be(2);

        data.Methods
            .Where(x => string.Equals(x.Path, "\"/v1/chat\"", StringComparison.Ordinal))
            .Select(x => x.ForcedRequestStreamValue)
            .Should()
            .BeEquivalentTo([false, true]);

        data.Methods
            .Where(x => string.Equals(x.Path, "\"/v2/chat\"", StringComparison.Ordinal))
            .Select(x => x.ForcedRequestStreamValue)
            .Should()
            .BeEquivalentTo([false, true]);
    }

    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void PrepareDerivedAllOfWithInheritedPropertyCollision_UsesNewAndInitializesBaseRequiredMembers(bool useLegacyPrepare)
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: opik-mini
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Feedback:
                                  required:
                                    - name
                                    - type
                                  type: object
                                  properties:
                                    id:
                                      type: string
                                      format: uuid
                                      readOnly: true
                                    name:
                                      minLength: 1
                                      type: string
                                    createdAt:
                                      type: string
                                      format: date-time
                                      readOnly: true
                                    type:
                                      type: string
                                      enum:
                                        - boolean
                                  discriminator:
                                    propertyName: type
                                    mapping:
                                      boolean: '#/components/schemas/BooleanFeedbackDefinition'
                                BooleanFeedbackDefinition:
                                  required:
                                    - details
                                    - name
                                    - type
                                  type: object
                                  allOf:
                                    - $ref: '#/components/schemas/Feedback'
                                    - type: object
                                      properties:
                                        details:
                                          $ref: '#/components/schemas/BooleanFeedbackDetail'
                                        created_at:
                                          type: string
                                          format: date-time
                                          readOnly: true
                                BooleanFeedbackDetail:
                                  type: object
                                  properties:
                                    trueLabel:
                                      type: string
                            """;

        var data = PrepareOpenApi(useLegacyPrepare, yaml, DefaultSettings);
        var model = data.Classes.Single(x => x.ClassName == "BooleanFeedbackDefinition");
        var generated = Sources.GenerateClassModel(model);

        generated.Should().Contain("public new global::System.DateTime? CreatedAt");
        generated.Should().Contain("string name");
        generated.Should().Contain("base.Name = name");
    }

    private static AutoSDK.Models.Data PreparePetstoreWithExclusions(bool useLegacyPrepare, string yaml, AutoSDK.Models.Settings settings)
    {
        return PrepareOpenApi(useLegacyPrepare, yaml, settings);
    }

    private static AutoSDK.Models.Data PrepareOpenApi(bool useLegacyPrepare, string yaml, AutoSDK.Models.Settings settings)
    {
        settings = settings with
        {
            Namespace = "TestNamespace",
            ClassName = "TestClient",
            IgnoreOpenApiErrors = true,
            IgnoreOpenApiWarnings = true,
            MethodNamingConvention = MethodNamingConvention.OperationIdWithDots,
            JsonSerializerType = JsonSerializerType.SystemTextJson,
        };

        return useLegacyPrepare
            ? Data.Prepare(((yaml, settings), GlobalSettings: settings))
            : CSharpPipeline.PrepareAndEnrich(((yaml, settings), GlobalSettings: settings));
    }
}
