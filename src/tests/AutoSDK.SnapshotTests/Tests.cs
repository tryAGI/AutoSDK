using AutoSDK.Serialization.Json;
using AutoSDK.SourceGenerators;
using Microsoft.CodeAnalysis;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    [TestMethod]
    [DataRow("", JsonSerializerType.NewtonsoftJson)]
    [DataRow("", JsonSerializerType.SystemTextJson)]
    // To test some private API
    //[DataRow("openapi.json", JsonSerializerType.SystemTextJson)]
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
    [DataRow("security.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("security.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("stream-variants.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("stream-variants.yaml", JsonSerializerType.SystemTextJson)]
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
    [DataRow("deepinfra.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("deepinfra.json", JsonSerializerType.SystemTextJson)]
    [DataRow("circular-refs.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("circular-refs.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("additional-properties-collision.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("additional-properties-collision.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("elevenlabs-realtime-stt.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("elevenlabs-realtime-stt.json", JsonSerializerType.SystemTextJson)]
    [DataRow("openai-realtime.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("openai-realtime.json", JsonSerializerType.SystemTextJson)]
    [DataRow("elevenlabs-realtime-stt-xref.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("elevenlabs-realtime-stt-xref.json", JsonSerializerType.SystemTextJson)]
    [DataRow("xai-realtime.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("xai-realtime.json", JsonSerializerType.SystemTextJson)]
    [DataRow("deepgram-multichannel.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("deepgram-multichannel.json", JsonSerializerType.SystemTextJson)]
    [DataRow("deepgram-const-discriminator.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("deepgram-const-discriminator.json", JsonSerializerType.SystemTextJson)]
    [DataRow("deepgram-inline-payloads.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("deepgram-inline-payloads.json", JsonSerializerType.SystemTextJson)]
    [DataRow("blackforestlabs.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("blackforestlabs.json", JsonSerializerType.SystemTextJson)]
    [DataRow("blandai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("blandai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("braintrust.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("braintrust.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("bravesearch.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("bravesearch.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("browserbase.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("browserbase.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("cartesia.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("cartesia.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("chroma.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("chroma.json", JsonSerializerType.SystemTextJson)]
    [DataRow("composio.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("composio.json", JsonSerializerType.SystemTextJson)]
    [DataRow("coze.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("coze.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("cursoragents.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("cursoragents.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("deepl.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("deepl.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("descript.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("descript.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("did.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("did.json", JsonSerializerType.SystemTextJson)]
    [DataRow("doclingserve.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("doclingserve.json", JsonSerializerType.SystemTextJson)]
    [DataRow("e2b.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("e2b.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("exa.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("exa.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("fal.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("fal.json", JsonSerializerType.SystemTextJson)]
    [DataRow("firecrawl.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("firecrawl.json", JsonSerializerType.SystemTextJson)]
    [DataRow("fishaudio.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("fishaudio.json", JsonSerializerType.SystemTextJson)]
    [DataRow("flowise.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("flowise.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("forem.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("forem.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("gladia.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("gladia.json", JsonSerializerType.SystemTextJson)]
    [DataRow("google-gemini-discovery.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("google-gemini-discovery.json", JsonSerializerType.SystemTextJson)]
    [DataRow("groq.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("groq.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("groundx.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("groundx.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("guardrails.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("guardrails.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("hedra.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("hedra.json", JsonSerializerType.SystemTextJson)]
    [DataRow("helicone.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("helicone.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("humanloop.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("humanloop.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("humeai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("humeai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("klingai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("klingai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("labelstudio.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("labelstudio.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("lakera.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("lakera.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("langfuse.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("langfuse.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("letta.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("letta.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("llamaparse.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("llamaparse.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("mem0.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("mem0.json", JsonSerializerType.SystemTextJson)]
    [DataRow("meshcapade.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("meshcapade.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("meshy.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("meshy.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("milvus.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("milvus.json", JsonSerializerType.SystemTextJson)]
    [DataRow("mixedbread.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("mixedbread.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("murf.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("murf.json", JsonSerializerType.SystemTextJson)]
    [DataRow("nanonets.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("nanonets.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("nightfallai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("nightfallai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("nixtla.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("nixtla.json", JsonSerializerType.SystemTextJson)]
    [DataRow("openrouter.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("openrouter.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("opik.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("opik.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("phoenix.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("phoenix.json", JsonSerializerType.SystemTextJson)]
    [DataRow("photoroom.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("photoroom.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("portkey.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("portkey.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("predictionguard.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("predictionguard.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("promptlayer.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("promptlayer.json", JsonSerializerType.SystemTextJson)]
    [DataRow("qdrant.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("qdrant.json", JsonSerializerType.SystemTextJson)]
    [DataRow("reka.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("reka.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("retellai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("retellai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("revai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("revai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("roboflow.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("roboflow.json", JsonSerializerType.SystemTextJson)]
    [DataRow("sarvamai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("sarvamai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("serper.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("serper.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("shotstack.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("shotstack.json", JsonSerializerType.SystemTextJson)]
    [DataRow("speechmatics.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("speechmatics.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("stabilityai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("stabilityai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("synthesia.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("synthesia.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("tavily.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("tavily.json", JsonSerializerType.SystemTextJson)]
    [DataRow("tavus.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("tavus.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("tripo.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("tripo.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("turbopuffer.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("turbopuffer.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("twelvelabs.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("twelvelabs.json", JsonSerializerType.SystemTextJson)]
    [DataRow("upstage.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("upstage.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("vapi.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("vapi.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("voyageai.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("voyageai.yaml", JsonSerializerType.SystemTextJson)]
    [DataRow("weave.json", JsonSerializerType.NewtonsoftJson)]
    [DataRow("weave.json", JsonSerializerType.SystemTextJson)]
    [DataRow("writer.yaml", JsonSerializerType.NewtonsoftJson)]
    [DataRow("writer.yaml", JsonSerializerType.SystemTextJson)]
    public Task SdkGenerator(string fileName, JsonSerializerType jsonSerializerType)
    {
        if (fileName == "")
        {
            return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [], callerName: "Empty", additionalGenerators: [new CliGenerator()]);
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
                ["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdSplit",
                ["build_property.AutoSDK_ExcludeDeprecatedOperations"] = "true",
                //["build_property.AutoSDK_JsonSerializerContext"] = "SourceGenerationContext",
                //["build_property.AutoSDK_GenerateMethods"] = "true",
            },
            "elevenlabs.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_MethodNamingConvention"] = "MethodAndPath",
            },
            "elevenlabs-realtime-stt.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "G.SourceGenerationContext"
                    : string.Empty,
            },
            "openai-realtime.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "G.SourceGenerationContext"
                    : string.Empty,
            },
            "elevenlabs-realtime-stt-xref.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_TypesNamespace"] = "ExternalTypes",
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "ExternalTypes.SourceGenerationContext"
                    : string.Empty,
            },
            "xai-realtime.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "G.SourceGenerationContext"
                    : string.Empty,
            },
            "deepgram-multichannel.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "G.SourceGenerationContext"
                    : string.Empty,
            },
            "deepgram-const-discriminator.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "G.SourceGenerationContext"
                    : string.Empty,
            },
            "deepgram-inline-payloads.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_JsonSerializerContext"] = jsonSerializerType is JsonSerializerType.SystemTextJson
                    ? "G.SourceGenerationContext"
                    : string.Empty,
            },
            "luma.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ComputeDiscriminators"] = "true",
            },
            _ => new Dictionary<string, string>(),
        };
        var supportSources = fileName switch
        {
            "elevenlabs-realtime-stt-xref.json" => new[]
            {
                """
                #nullable enable

                namespace ExternalTypes
                {
                    public sealed partial class InputAudioChunkPayload
                    {
                    }

                    public readonly partial struct ServerEvent
                    {
                    }

                    public sealed partial class JsonSerializerContextTypes
                    {
                    }
                }
                """
            },
            _ => [],
        };

        return CheckSourceAsync<SdkGenerator>(jsonSerializerType, [
            new CustomAdditionalText(
                path: resource.FileName,
                text: resource.AsString())
        ], Path.GetFileNameWithoutExtension(fileName), globalOptions, supportSources: supportSources, additionalGenerators: [new CliGenerator()]);
    }
    
    [TestMethod]
    [DataRow("")]
    //[DataRow("ai21.json")]
    [DataRow("anthropic.yaml")]
    [DataRow("assemblyai.yaml")]
    [DataRow("cohere.yaml")]
    //[DataRow("dedoose.json")]
    //[DataRow("github.yaml")]
    //[DataRow("huggingface.yaml")]
    //[DataRow("ipinfo.yaml")]
    //[DataRow("langsmith.json")]
    //[DataRow("leonardo.yaml")]
    //[DataRow("mystic.yaml")]
    //[DataRow("ollama.yaml")]
    //[DataRow("openai.yaml")]
    //[DataRow("petstore.yaml")]
    [DataRow("replicate.json")]
    //[DataRow("special-cases.yaml")]
    //[DataRow("together.yaml")]
    [DataRow("twitch.json")]
    [DataRow("filtering.yaml")]
    [DataRow("heygen.yaml")]
    [DataRow("instill.yaml")]
    [DataRow("ideogram.yaml")]
    [DataRow("google-gemini.yaml")]
    //[DataRow("vectara.yaml")]
    //[DataRow("weaviate.yaml")]
    //[DataRow("elevenlabs.json")]
    [DataRow("jina.json")]
    [DataRow("runway.yaml")]
    [DataRow("recraft.yaml")]
    //[DataRow("luma.yaml")]
    [DataRow("ultravox.yaml")]
    [DataRow("deepinfra.json")]
    [DataRow("circular-refs.yaml")]
    // New specs — representative coverage across categories
    [DataRow("qdrant.json")]
    [DataRow("reka.yaml")]
    [DataRow("writer.yaml")]
    [DataRow("groq.yaml")]
    [DataRow("exa.yaml")]
    [DataRow("tavily.json")]
    [DataRow("cartesia.yaml")]
    [DataRow("deepl.yaml")]
    [DataRow("blackforestlabs.json")]
    [DataRow("opik.yaml")]
    [DataRow("milvus.json")]
    [DataRow("chroma.json")]
    [DataRow("lakera.yaml")]
    [DataRow("mixedbread.yaml")]
    [DataRow("upstage.yaml")]
    [DataRow("sarvamai.yaml")]
    [DataRow("firecrawl.json")]
    [DataRow("browserbase.yaml")]
    public Task CliGenerator(string fileName)
    {
        if (fileName == "")
        {
            return CheckCliSourceAsync<CliGenerator>([], callerName: "Empty", additionalGenerators: [new SdkGenerator()]);
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
                //["build_property.AutoSDK_GenerateSdk"] = "false",
                //["build_property.AutoSDK_GenerateModels"] = "true",
                //["build_property.AutoSDK_IncludeModels"] = "prediction_request",
            },
            "openai.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ClassName"] = "OpenAiClient",
                ["build_property.AutoSDK_JsonSerializerContext"] = "G.SourceGenerationContext",
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
                ["build_property.AutoSDK_MethodNamingConvention"] = "OperationIdSplit",
                ["build_property.AutoSDK_ExcludeDeprecatedOperations"] = "true",
                //["build_property.AutoSDK_JsonSerializerContext"] = "SourceGenerationContext",
                //["build_property.AutoSDK_GenerateMethods"] = "true",
            },
            "elevenlabs.json" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_MethodNamingConvention"] = "MethodAndPath",
            },
            "luma.yaml" => new Dictionary<string, string>
            {
                ["build_property.AutoSDK_ComputeDiscriminators"] = "true",
            },
            _ => new Dictionary<string, string>(),
        };
        
        return CheckCliSourceAsync<CliGenerator>([
            new CustomAdditionalText(
                path: resource.FileName,
                text: resource.AsString())
        ], Path.GetFileNameWithoutExtension(fileName), globalOptions, additionalGenerators: [new SdkGenerator()]);
    }
    
    [TestMethod]
    public Task ParallelGeneration()
    {
        var resources = new[]
        {
            new H.Resource("petstore.yaml"),
            new H.Resource("recraft.yaml"),
        };
        var texts = resources
            .Select(AdditionalText (x) => new CustomAdditionalText(
                path: x.FileName,
                text: x.AsString()))
            .ToList();

        return CheckSourceAsync<SdkGenerator>(
            jsonSerializerType: JsonSerializerType.SystemTextJson,
            callerName: nameof(ParallelGeneration),
            additionalTexts: texts,
            additionalTextOptions: resources.ToDictionary(
                x => x.FileName,
                x => new Dictionary<string, string>
                {
                    ["build_metadata.AdditionalFiles.AutoSDK_Namespace"] = Path.GetFileNameWithoutExtension(x.FileName),
                    ["build_metadata.AdditionalFiles.AutoSDK_ClassName"] = Path.GetFileNameWithoutExtension(x.FileName) + "Client",
                }));
    }

    [TestMethod]
    public void DiagnosticsSnapshotsShouldStayEmpty()
    {
        var snapshotsDirectory = Path.GetFullPath(Path.Combine(
            AppContext.BaseDirectory,
            "..",
            "..",
            "..",
            "..",
            "..",
            "..",
            "src",
            "tests",
            "AutoSDK.SnapshotTests",
            "Snapshots"));
        var diagnosticsFiles = Directory.GetFiles(
            snapshotsDirectory,
            "Tests.*Diagnostics.verified.txt",
            SearchOption.AllDirectories);

        diagnosticsFiles.Should().NotBeEmpty();

        foreach (var diagnosticsFile in diagnosticsFiles)
        {
            File.ReadAllText(diagnosticsFile)
                .TrimStart('\uFEFF')
                .Trim()
                .Should()
                .Be("[]", $"diagnostics snapshots must stay empty: {diagnosticsFile}");
        }
    }
}
