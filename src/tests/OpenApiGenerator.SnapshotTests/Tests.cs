using Microsoft.CodeAnalysis;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using OpenApiGenerator;

namespace H.Generators.IntegrationTests;

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
    
    [TestMethod]
    public Task Empty()
    {
        return CheckSourceAsync<ModelGenerator>(
            Array.Empty<AdditionalText>());
    }
    
    [TestMethod]
    public Task YamlWithLocalFileUseNSwag()
    {
        return CheckSourceAsync<NSwagGenerator>(new AdditionalText[]
        {
            new CustomAdditionalText("openapi.yaml", Resources.ipinfo_yaml.AsString()),
        }, new Dictionary<string, string>
        {
            ["build_property.OpenApiGenerator_UseNSwag"] = "true",
        });
    }
    
    [TestMethod]
    public Task OpenAi()
    {
        return CheckSourceAsync<ModelGenerator>(new AdditionalText[]
        {
            new CustomAdditionalText(Resources.openai_yaml.FileName, Resources.openai_yaml.AsString()),
        }, new Dictionary<string, string>
        {
            ["build_property.OpenApiGenerator_IncludeModels"] = "Error;ErrorResponse;ListModelsResponse;Model;DeleteModelResponse;CreateCompletionRequest",
        });
    }
    
    [TestMethod]
    public Task YamlWithLocalFile()
    {
        return CheckSourceAsync<ModelGenerator>(new AdditionalText[]
        {
            new CustomAdditionalText("openapi.yaml", Resources.ipinfo_yaml.AsString()),
        });
    }

    [TestMethod]
    public Task OpenApi3_0_Yaml()
    {
        var yaml = PetStore.Serialize(OpenApiSpecVersion.OpenApi3_0, OpenApiFormat.Yaml);
        
        return CheckSourceAsync<ModelGenerator>(new AdditionalText[]
        {
            new CustomAdditionalText("openapi.yaml", yaml),
        });
    }

    [TestMethod]
    public Task YamlWithUrl()
    {
        return CheckSourceAsync<ModelGenerator>(new AdditionalText[]
        {
            new CustomAdditionalText("https://dedoose-rest-api.onrender.com/swagger/v1/swagger.json", string.Empty),
        });
    }
}