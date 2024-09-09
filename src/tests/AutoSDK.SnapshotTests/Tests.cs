using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using AutoSDK.Serialization.Json;
using AutoSDK.SourceGenerators;

namespace AutoSDK.SnapshotTests;

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
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [], new Dictionary<string, string>
        {
            //["build_property.AutoSDK_GenerateConstructors"] = "true",
            //["build_property.AutoSDK_GenerateMethods"] = "true",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task LangSmith(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.langsmith_yaml.FileName,
                text: H.Resources.langsmith_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdSplit",
            ["build_property.AutoSDK_ExcludeDeprecatedOperations"] = "true",
            //["build_property.AutoSDK_JsonSerializerContext"] = "SourceGenerationContext",
            //["build_property.AutoSDK_GenerateMethods"] = "true",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task HuggingFace(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.huggingface_yaml.FileName,
                text: H.Resources.huggingface_yaml.AsString())
        ]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Ai21(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.ai21_yaml.FileName,
                text: H.Resources.ai21_yaml.AsString())
        ]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Cohere(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.cohere_yaml.FileName,
                text: H.Resources.cohere_yaml.AsString())
        ]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Leonardo(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.leonardo_yaml.FileName,
                text: H.Resources.leonardo_yaml.AsString())
        ], new Dictionary<string, string>
        {
            //["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdSplit",
            //["build_property.AutoSDK_ExcludeDeprecatedOperations"] = "true",
            //["build_property.AutoSDK_JsonSerializerContext"] = "SourceGenerationContext",
            //["build_property.AutoSDK_GenerateMethods"] = "true",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Anthropic(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.anthropic_yaml.FileName,
                text: H.Resources.anthropic_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.AutoSDK_GenerateJsonSerializerContextTypes"] = "true",
            // ["build_property.AutoSDK_GenerateSdk"] = "false",
            // ["build_property.AutoSDK_GenerateModels"] = "true",
            // ["build_property.AutoSDK_IncludeModels"] = "CreateMessageRequest",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Ollama(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.ollama_yaml.FileName,
                text: H.Resources.ollama_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.AutoSDK_GenerateJsonSerializerContextTypes"] = "true",
            //["build_property.AutoSDK_GenerateConstructors"] = "true",
            //["build_property.AutoSDK_GenerateMethods"] = "true",
            //["build_property.AutoSDK_IncludeOperationIds"] = "ListModels",
            //["build_property.AutoSDK_IncludeModels"] = "PushModelResponse",
            // ["build_property.AutoSDK_GenerateSdk"] = "false",
            // ["build_property.AutoSDK_GenerateModels"] = "false",
            // ["build_property.AutoSDK_GenerateMethods"] = "true",
            // ["build_property.AutoSDK_GenerateConstructors"] = "true",
            // ["build_property.AutoSDK_IncludeOperationIds"] = "checkBlob",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Dedoose(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.dedoose_json.FileName,
                text: H.Resources.dedoose_json.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.AutoSDK_GenerateJsonSerializerContextTypes"] = "true",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Replicate(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.replicate_yaml.FileName,
                text: H.Resources.replicate_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdWithDots",
            //["build_property.AutoSDK_GenerateSdk"] = "false",
            //["build_property.AutoSDK_GenerateModels"] = "true",
            //["build_property.AutoSDK_IncludeModels"] = "prediction_request",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task OpenAi(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.openai_yaml.FileName,
                text: H.Resources.openai_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.AutoSDK_ClassName"] = "OpenAiClient",
            // ["build_property.AutoSDK_GenerateSdk"] = "false",
            // ["build_property.AutoSDK_GenerateModels"] = "true",
            // ["build_property.AutoSDK_GenerateMethods"] = "false",
            // ["build_property.AutoSDK_GenerateConstructors"] = "false",
            //["build_property.AutoSDK_IncludeOperationIds"] = "listVectorStores",
            //["build_property.AutoSDK_IncludeModels"] = "CreateAssistantRequest",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task AssemblyAi(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.assemblyai_yaml.FileName,
                text: H.Resources.assemblyai_yaml.AsString())
        ]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task GitHub(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.github_yaml.FileName,
                text: H.Resources.github_yaml.AsString())
        ], new Dictionary<string, string>
        {
            // ["build_property.AutoSDK_GenerateSdk"] = "false",
            // ["build_property.AutoSDK_GenerateModels"] = "false",
            // ["build_property.AutoSDK_GenerateMethods"] = "true",
            // ["build_property.AutoSDK_GenerateConstructors"] = "true",
            // ["build_property.AutoSDK_IncludeOperationIds"] = "orgs/enable-or-disable-security-product-on-all-org-repos",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Twitch(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.twitch_json.FileName,
                text: H.Resources.twitch_json.AsString())
        ]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task SpecialCases(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.special_cases_yaml.FileName,
                text: H.Resources.special_cases_yaml.AsString())
        ]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Together(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.together_yaml.FileName,
                text: H.Resources.together_yaml.AsString())
        ]);
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task Filtering(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: H.Resources.github_yaml.FileName,
                text: H.Resources.github_yaml.AsString())
        ], new Dictionary<string, string>
        {
            // migrations/list-for-org
            ["build_property.AutoSDK_IncludeTags"] = "migrations",
            //["build_property.AutoSDK_IncludeTags"] = "actions;activity;apps;billing;checks;code-scanning;codes-of-conduct;emojis;dependabot;dependency-graph;gists;git;gitignore;issues;licenses;markdown;merge-queue;meta;migrations;oidc;orgs;packages;projects;pulls;rate-limit;reactions;repos;search;secret-scanning;teams;users;codespaces;copilot;security-advisories;interactions;classroom;desktop;enterprise-teams",
            //["build_property.AutoSDK_IncludeModels"] = "CreateEmbeddingRequest;CreateModerationResponse;Error;ErrorResponse;ListModelsResponse;Model;DeleteModelResponse;CreateCompletionRequest",
        });
    }
    
    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task IpInfo(JsonSerializerType jsonSerializerType)
    {
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: "openapi.yaml",
                text: H.Resources.ipinfo_yaml.AsString()),
        ], new Dictionary<string, string>
        {
            //["build_property.AutoSDK_GenerateConstructors"] = "true",
            //["build_property.AutoSDK_GenerateMethods"] = "true",
        });
    }

    [DataTestMethod]
    [DataRow(JsonSerializerType.SystemTextJson)]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    public Task OpenApi3_0_Yaml(JsonSerializerType jsonSerializerType)
    {
        var yaml = PetStore.Serialize(OpenApiSpecVersion.OpenApi3_0, OpenApiFormat.Yaml);
        
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText("openapi.yaml", yaml),
        ], new Dictionary<string, string>
        {
            //["build_property.AutoSDK_GenerateConstructors"] = "true",
            //["build_property.AutoSDK_GenerateMethods"] = "true",
        });
    }
    //
    // [DataTestMethod]
    // [DataRow(JsonSerializerType.SystemTextJson)]
    // [DataRow(JsonSerializerType.NewtonsoftJson)]
    // public Task YamlWithUrl(JsonSerializerType jsonSerializerType)
    // {
    //     return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
    //         new CustomAdditionalText("https://dedoose-rest-api.onrender.com/swagger/v1/swagger.json", string.Empty),
    //     ]);
    // }
}