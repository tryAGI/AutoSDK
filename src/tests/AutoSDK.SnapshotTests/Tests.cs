using AutoSDK.Serialization.Json;
using AutoSDK.SourceGenerators;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    [DataTestMethod]
    [DataRow("", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", JsonSerializerType.SystemTextJson)]
    [DataRow("ai21.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("ai21.json", JsonSerializerType.SystemTextJson)]
    [DataRow("anthropic.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("anthropic.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("assemblyai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("assemblyai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("cohere.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("cohere.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("dedoose.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("dedoose.json", JsonSerializerType.SystemTextJson)]
    [DataRow("github.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("github.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("huggingface.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("huggingface.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("ipinfo.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("ipinfo.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("langsmith.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("langsmith.json", JsonSerializerType.SystemTextJson)]
    [DataRow("leonardo.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("leonardo.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("mystic.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("mystic.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("ollama.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("ollama.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("openai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("openai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("petstore.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("petstore.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("replicate.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("replicate.json", JsonSerializerType.SystemTextJson)]
    [DataRow("special-cases.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("special-cases.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("together.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("together.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("twitch.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("twitch.json", JsonSerializerType.SystemTextJson)]
    [DataRow("filtering.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("filtering.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("heygen.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("heygen.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("instill.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("instill.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("ideogram.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("ideogram.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("google-gemini.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("google-gemini.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("vectara.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("vectara.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("mistral.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("mistral.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("weaviate.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("weaviate.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("elevenlabs.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("elevenlabs.json", JsonSerializerType.SystemTextJson)]
    [DataRow("jina.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("jina.json", JsonSerializerType.SystemTextJson)]
    [DataRow("runway.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("runway.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("recraft.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("recraft.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("luma.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("luma.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("ultravox.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("ultravox.yaml", JsonSerializerType.SystemTextJson)]
    public Task SdkGenerator(string fileName, JsonSerializerType jsonSerializerType)
    {
        if (fileName == "")
        {
            return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [], callerName: "Empty");
        }
        
        var resource = new H.Resource(fileName);

        var globalOptions = fileName switch
        {
            "cohere.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ComputeDiscriminators"] = "true",
            },
            "anthropic.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ComputeDiscriminators"] = "true",
            },
            "github.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ComputeDiscriminators"] = "true",
            },
            "together.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ComputeDiscriminators"] = "true",
            },
            "mystic.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_MethodNamingConvention"] = "Summary",
            },
            "replicate.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdWithDots",
                ["build_property.AutoSDK_IgnoreOpenApiErrors"] = "true",
                //["build_property.AutoSDK_GenerateSdk"] = "false",
                //["build_property.AutoSDK_GenerateModels"] = "true",
                //["build_property.AutoSDK_IncludeModels"] = "prediction_request",
            },
            "openai.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ClassName"] = "OpenAiClient",
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "G.SourceGenerationContext"
                    : string.Empty,
                ["build_property.AutoSDK_IgnoreOpenApiErrors"] = "true",
                // ["build_property.AutoSDK_GenerateSdk"] = "false",
                // ["build_property.AutoSDK_GenerateModels"] = "true",
                // ["build_property.AutoSDK_GenerateMethods"] = "false",
                // ["build_property.AutoSDK_GenerateConstructors"] = "false",
                //["build_property.AutoSDK_IncludeOperationIds"] = "listVectorStores",
                //["build_property.AutoSDK_IncludeModels"] = "CreateAssistantRequest",
            },
            "filtering.yaml" => new Dictionary<string, string>
            {
                // migrations/list-for-org
                ["build_property.AutoSDK_IncludeTags"] = "migrations",
                //["build_property.AutoSDK_IncludeTags"] = "actions;activity;apps;billing;checks;code-scanning;codes-of-conduct;emojis;dependabot;dependency-graph;gists;git;gitignore;issues;licenses;markdown;merge-queue;meta;migrations;oidc;orgs;packages;projects;pulls;rate-limit;reactions;repos;search;secret-scanning;teams;users;codespaces;copilot;security-advisories;interactions;classroom;desktop;enterprise-teams",
                //["build_property.AutoSDK_IncludeModels"] = "CreateEmbeddingRequest;CreateModerationResponse;Error;ErrorResponse;ListModelsResponse;Model;DeleteModelResponse;CreateCompletionRequest",
            },
            "langsmith.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_IgnoreOpenApiErrors"] = "true",
                ["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdSplit",
                ["build_property.AutoSDK_ExcludeDeprecatedOperations"] = "true",
                //["build_property.AutoSDK_JsonSerializerContext"] = "SourceGenerationContext",
                //["build_property.AutoSDK_GenerateMethods"] = "true",
            },
            "elevenlabs.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_IgnoreOpenApiErrors"] = "true",
                ["build_property.AutoSDK_MethodNamingConvention"] = "MethodAndPath",
            },
            "ai21.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_IgnoreOpenApiErrors"] = "true",
            },
            "luma.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_IgnoreOpenApiErrors"] = "true",
                ["build_property.AutoSDK_ComputeDiscriminators"] = "true",
            },
            _ => new Dictionary<string, string>(),
        };
        
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: resource.FileName,
                text: resource.AsString())
        ], Path.GetFileNameWithoutExtension(fileName), globalOptions);
    }
}