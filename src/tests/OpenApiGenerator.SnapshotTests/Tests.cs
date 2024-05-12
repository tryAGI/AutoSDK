using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Generators;

namespace OpenApiGenerator.SnapshotTests;

public partial class Tests
{
    private static OpenApiDocument PetStore { get; } = new OpenApiDocument
    {
        Info = new OpenApiInfo
        {
            Version = "1.0.0",
            Title = "Swagger Petstore (Simple)",
        },
        Servers = new List<OpenApiServer>
        {
            new() { Url = "http://petstore.swagger.io/api" },
        },
        Paths = new OpenApiPaths
        {
            ["/pets"] = new()
            {
                Operations = new Dictionary<OperationType, OpenApiOperation>
                {
                    [OperationType.Get] = new()
                    {
                        Description = "Returns all pets from the system that the user has access to",
                        Responses = new OpenApiResponses
                        {
                            ["200"] = new()
                            {
                                Description = "OK",
                            },
                        },
                    },
                },
            },
        },
    };
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Empty(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<ModelGenerator>(jsonSerializerType, []);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Ollama(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<ModelGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.ollamacurated_yaml.FileName,
                text: H.Resources.ollamacurated_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.OpenApiGenerator_GenerateConstructors"] = "true",
            ["build_property.OpenApiGenerator_GenerateMethods"] = "true",
            //["build_property.OpenApiGenerator_IncludeOperationIds"] = "ListModels",
            //["build_property.OpenApiGenerator_IncludeModels"] = "CreateModerationResponse;Error;ErrorResponse;ListModelsResponse;Model;DeleteModelResponse;CreateCompletionRequest",
        }, additionalGenerators: [new ClientGenerator()]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task OpenAi(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<ModelGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.openai_yaml.FileName,
                text: H.Resources.openai_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.OpenApiGenerator_GenerateConstructors"] = "true",
            ["build_property.OpenApiGenerator_GenerateMethods"] = "true",
            ["build_property.OpenApiGenerator_IncludeOperationIds"] = "ListModels",
            ["build_property.OpenApiGenerator_IncludeModels"] = "CreateModerationResponse;Error;ErrorResponse;ListModelsResponse;Model;DeleteModelResponse;CreateCompletionRequest",
        }, additionalGenerators: [new ClientGenerator()]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task OpenAi_CreateCompletionResponse(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<ModelGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.openai_yaml.FileName,
                text: H.Resources.openai_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.OpenApiGenerator_IncludeModels"] = "CreateCompletionResponse",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task YamlWithLocalFile(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<ModelGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: "openapi.yaml",
                text: H.Resources.ipinfo_yaml.AsString()),
        ]);
    }

    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task OpenApi3_0_Yaml(JsonSerializerType jsonSerializerType)
    {
        var yaml = PetStore.Serialize(OpenApiSpecVersion.OpenApi3_0, OpenApiFormat.Yaml);
        
        return CheckSourceAsync<ModelGenerator>(jsonSerializerType, [
            new CustomAdditionalText("openapi.yaml", yaml),
        ]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task YamlWithUrl(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<ModelGenerator>(jsonSerializerType, [
            new CustomAdditionalText("https://dedoose-rest-api.onrender.com/swagger/v1/swagger.json", string.Empty),
        ]);
    }
}