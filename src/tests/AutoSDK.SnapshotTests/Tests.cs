using AutoSDK.Serialization.Json;
using AutoSDK.SourceGenerators;
using Microsoft.CodeAnalysis;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    [DataTestMethod]
    [DataRow("Empty", "", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Empty", "", JsonSerializerType.SystemTextJson)]
    [DataRow("Ai21", "ai21.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Ai21", "ai21.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("Anthropic", "anthropic.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Anthropic", "anthropic.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("AssemblyAi", "assemblyai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("AssemblyAi", "assemblyai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("Cohere", "cohere.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Cohere", "cohere.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("Dedoose", "dedoose.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Dedoose", "dedoose.json", JsonSerializerType.SystemTextJson)]
    [DataRow("GitHub", "github.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("GitHub", "github.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("HuggingFace", "huggingface.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("HuggingFace", "huggingface.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("IpInfo", "ipinfo.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("IpInfo", "ipinfo.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("LangSmith", "langsmith.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("LangSmith", "langsmith.json", JsonSerializerType.SystemTextJson)]
    [DataRow("Leonardo", "leonardo.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Leonardo", "leonardo.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("Mystic", "mystic.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Mystic", "mystic.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("Ollama", "ollama.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Ollama", "ollama.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("OpenAi", "openai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("OpenAi", "openai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("PetStore", "petstore.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("PetStore", "petstore.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("Replicate", "replicate.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Replicate", "replicate.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("SpecialCases", "special-cases.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("SpecialCases", "special-cases.yaml", JsonSerializerType.SystemTextJson)]
    // [DataRow("Together", "together.yaml", JsonSerializerType.NewtonsoftJson)]
    // [DataRow("Together", "together.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("Twitch", "twitch.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Twitch", "twitch.json", JsonSerializerType.SystemTextJson)]
    [DataRow("Filtering", "github.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("Filtering", "github.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("", "heygen.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", "heygen.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("", "instill.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", "instill.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("", "ideogram.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", "ideogram.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("", "google-gemini.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", "google-gemini.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("", "vectara.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", "vectara.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("", "mistral.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", "mistral.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("", "weaviate.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", "weaviate.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("elevenlabs", "elevenlabs.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("elevenlabs", "elevenlabs.json", JsonSerializerType.SystemTextJson)]
    public Task SdkGenerator(string callerName, string fileName, JsonSerializerType jsonSerializerType)
    {
        if (callerName == "Empty")
        {
            return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [], callerName);
        }
        if (string.IsNullOrWhiteSpace(callerName))
        {
            callerName = Path.GetFileNameWithoutExtension(fileName);
        }
        
        var resource = new H.Resource(fileName);

        var globalOptions = callerName switch
        {
            "Mystic" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_MethodNamingConvention"] = "Summary",
            },
            "Replicate" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdWithDots",
                //["build_property.AutoSDK_GenerateSdk"] = "false",
                //["build_property.AutoSDK_GenerateModels"] = "true",
                //["build_property.AutoSDK_IncludeModels"] = "prediction_request",
            },
            "OpenAi" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ClassName"] = "OpenAiClient",
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "G.SourceGenerationContext"
                    : string.Empty,
                // ["build_property.AutoSDK_GenerateSdk"] = "false",
                // ["build_property.AutoSDK_GenerateModels"] = "true",
                // ["build_property.AutoSDK_GenerateMethods"] = "false",
                // ["build_property.AutoSDK_GenerateConstructors"] = "false",
                //["build_property.AutoSDK_IncludeOperationIds"] = "listVectorStores",
                //["build_property.AutoSDK_IncludeModels"] = "CreateAssistantRequest",
            },
            "Filtering" => new Dictionary<string, string>
            {
                // migrations/list-for-org
                ["build_property.AutoSDK_IncludeTags"] = "migrations",
                //["build_property.AutoSDK_IncludeTags"] = "actions;activity;apps;billing;checks;code-scanning;codes-of-conduct;emojis;dependabot;dependency-graph;gists;git;gitignore;issues;licenses;markdown;merge-queue;meta;migrations;oidc;orgs;packages;projects;pulls;rate-limit;reactions;repos;search;secret-scanning;teams;users;codespaces;copilot;security-advisories;interactions;classroom;desktop;enterprise-teams",
                //["build_property.AutoSDK_IncludeModels"] = "CreateEmbeddingRequest;CreateModerationResponse;Error;ErrorResponse;ListModelsResponse;Model;DeleteModelResponse;CreateCompletionRequest",
            },
            "LangSmith" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdSplit",
                ["build_property.AutoSDK_ExcludeDeprecatedOperations"] = "true",
                //["build_property.AutoSDK_JsonSerializerContext"] = "SourceGenerationContext",
                //["build_property.AutoSDK_GenerateMethods"] = "true",
            },
            "elevenlabs" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_IgnoreOpenApiErrors"] = "true",
            },
            _ => new Dictionary<string, string>(),
        };
        
        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: resource.FileName,
                text: resource.AsString())
        ], callerName, globalOptions);
    }
}