//HintName: G.JsonConverters.CredentialsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CredentialsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CredentialsItem>
    {
        /// <inheritdoc />
        public override global::G.CredentialsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowUserEditableCredentialDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowUserEditableCredentialDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowUserEditableCredentialDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateAnthropicCredentialDTO? anthropic = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAnthropicCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAnthropicCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAnthropicCredentialDTO)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateAnthropicBedrockCredentialDTO? anthropicBedrock = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.AnthropicBedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAnthropicBedrockCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAnthropicBedrockCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAnthropicBedrockCredentialDTO)}");
                anthropicBedrock = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateAnyscaleCredentialDTO? anyscale = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Anyscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAnyscaleCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAnyscaleCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAnyscaleCredentialDTO)}");
                anyscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateAssemblyAICredentialDTO? assemblyAi = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.AssemblyAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssemblyAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssemblyAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAssemblyAICredentialDTO)}");
                assemblyAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateAzureCredentialDTO? azure = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAzureCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAzureCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAzureCredentialDTO)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateAzureOpenAICredentialDTO? azureOpenai = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.AzureOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAzureOpenAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAzureOpenAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAzureOpenAICredentialDTO)}");
                azureOpenai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateByoSipTrunkCredentialDTO? byoSipTrunk = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.ByoSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateByoSipTrunkCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateByoSipTrunkCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateByoSipTrunkCredentialDTO)}");
                byoSipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateCartesiaCredentialDTO? cartesia = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Cartesia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCartesiaCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCartesiaCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCartesiaCredentialDTO)}");
                cartesia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateCerebrasCredentialDTO? cerebras = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Cerebras)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCerebrasCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCerebrasCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCerebrasCredentialDTO)}");
                cerebras = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateCloudflareCredentialDTO? cloudflare = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Cloudflare)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCloudflareCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCloudflareCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCloudflareCredentialDTO)}");
                cloudflare = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateCustomLLMCredentialDTO? customLlm = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.CustomLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCustomLLMCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCustomLLMCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCustomLLMCredentialDTO)}");
                customLlm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateDeepgramCredentialDTO? deepgram = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Deepgram)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDeepgramCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDeepgramCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateDeepgramCredentialDTO)}");
                deepgram = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateDeepInfraCredentialDTO? deepinfra = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Deepinfra)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDeepInfraCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDeepInfraCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateDeepInfraCredentialDTO)}");
                deepinfra = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateDeepSeekCredentialDTO? deepSeek = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.DeepSeek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDeepSeekCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDeepSeekCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateDeepSeekCredentialDTO)}");
                deepSeek = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateElevenLabsCredentialDTO? elevenlabs = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Elevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateElevenLabsCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateElevenLabsCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateElevenLabsCredentialDTO)}");
                elevenlabs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGcpCredentialDTO? gcp = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGcpCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGcpCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGcpCredentialDTO)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGladiaCredentialDTO? gladia = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Gladia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGladiaCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGladiaCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGladiaCredentialDTO)}");
                gladia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoHighLevelCredentialDTO? gohighlevel = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Gohighlevel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoHighLevelCredentialDTO)}");
                gohighlevel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoogleCredentialDTO? google = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Google)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoogleCredentialDTO)}");
                google = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGroqCredentialDTO? groq = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Groq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGroqCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGroqCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGroqCredentialDTO)}");
                groq = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateHumeCredentialDTO? hume = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Hume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateHumeCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateHumeCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateHumeCredentialDTO)}");
                hume = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateInflectionAICredentialDTO? inflectionAi = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.InflectionAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInflectionAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInflectionAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateInflectionAICredentialDTO)}");
                inflectionAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateLangfuseCredentialDTO? langfuse = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Langfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLangfuseCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLangfuseCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateLangfuseCredentialDTO)}");
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateLmntCredentialDTO? lmnt = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Lmnt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLmntCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLmntCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateLmntCredentialDTO)}");
                lmnt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateMakeCredentialDTO? make = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Make)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMakeCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMakeCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateMakeCredentialDTO)}");
                make = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateMistralCredentialDTO? mistral = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Mistral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMistralCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMistralCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateMistralCredentialDTO)}");
                mistral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateNeuphonicCredentialDTO? neuphonic = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Neuphonic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateNeuphonicCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateNeuphonicCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateNeuphonicCredentialDTO)}");
                neuphonic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateOpenAICredentialDTO? openai = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateOpenAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateOpenAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateOpenAICredentialDTO)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateOpenRouterCredentialDTO? openrouter = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Openrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateOpenRouterCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateOpenRouterCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateOpenRouterCredentialDTO)}");
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreatePerplexityAICredentialDTO? perplexityAi = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.PerplexityAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreatePerplexityAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreatePerplexityAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreatePerplexityAICredentialDTO)}");
                perplexityAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreatePlayHTCredentialDTO? playht = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Playht)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreatePlayHTCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreatePlayHTCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreatePlayHTCredentialDTO)}");
                playht = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateRimeAICredentialDTO? rimeAi = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.RimeAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateRimeAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateRimeAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateRimeAICredentialDTO)}");
                rimeAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateRunpodCredentialDTO? runpod = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Runpod)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateRunpodCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateRunpodCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateRunpodCredentialDTO)}");
                runpod = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateS3CredentialDTO? s3 = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateS3CredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateS3CredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateS3CredentialDTO)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSmallestAICredentialDTO? smallestAi = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.SmallestAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSmallestAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSmallestAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSmallestAICredentialDTO)}");
                smallestAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSpeechmaticsCredentialDTO? speechmatics = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Speechmatics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSpeechmaticsCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSpeechmaticsCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSpeechmaticsCredentialDTO)}");
                speechmatics = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSonioxCredentialDTO? soniox = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Soniox)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSonioxCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSonioxCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSonioxCredentialDTO)}");
                soniox = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSupabaseCredentialDTO? supabase = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Supabase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSupabaseCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSupabaseCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSupabaseCredentialDTO)}");
                supabase = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTavusCredentialDTO? tavus = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Tavus)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTavusCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTavusCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTavusCredentialDTO)}");
                tavus = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTogetherAICredentialDTO? togetherAi = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.TogetherAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTogetherAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTogetherAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTogetherAICredentialDTO)}");
                togetherAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTrieveCredentialDTO? trieve = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Trieve)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTrieveCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTrieveCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTrieveCredentialDTO)}");
                trieve = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTwilioCredentialDTO? twilio = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTwilioCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTwilioCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTwilioCredentialDTO)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateVonageCredentialDTO? vonage = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Vonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVonageCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVonageCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVonageCredentialDTO)}");
                vonage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateWebhookCredentialDTO? webhook = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateWebhookCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateWebhookCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateWebhookCredentialDTO)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateCustomCredentialDTO? customCredential = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.CustomCredential)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCustomCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCustomCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCustomCredentialDTO)}");
                customCredential = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateXAiCredentialDTO? xai = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateXAiCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateXAiCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateXAiCredentialDTO)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO? googleCalendarOauth2Client = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.GoogleCalendarOauth2Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO)}");
                googleCalendarOauth2Client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? googleCalendarOauth2Authorization = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO)}");
                googleCalendarOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? googleSheetsOauth2Authorization = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO)}");
                googleSheetsOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSlackOAuth2AuthorizationCredentialDTO? slackOauth2Authorization = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.SlackOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSlackOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSlackOAuth2AuthorizationCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSlackOAuth2AuthorizationCredentialDTO)}");
                slackOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateGoHighLevelMCPCredentialDTO? ghlOauth2Authorization = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.GhlOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelMCPCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelMCPCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateGoHighLevelMCPCredentialDTO)}");
                ghlOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateInworldCredentialDTO? inworld = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Inworld)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInworldCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInworldCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateInworldCredentialDTO)}");
                inworld = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateMinimaxCredentialDTO? minimax = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Minimax)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMinimaxCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMinimaxCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateMinimaxCredentialDTO)}");
                minimax = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateWellSaidCredentialDTO? wellsaid = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Wellsaid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateWellSaidCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateWellSaidCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateWellSaidCredentialDTO)}");
                wellsaid = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateEmailCredentialDTO? email = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.Email)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateEmailCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateEmailCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateEmailCredentialDTO)}");
                email = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateSlackWebhookCredentialDTO? slackWebhook = default;
            if (discriminator?.Provider == global::G.WorkflowUserEditableCredentialDiscriminatorProvider.SlackWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSlackWebhookCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSlackWebhookCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateSlackWebhookCredentialDTO)}");
                slackWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CredentialsItem(
                discriminator?.Provider,
                anthropic,

                anthropicBedrock,

                anyscale,

                assemblyAi,

                azure,

                azureOpenai,

                byoSipTrunk,

                cartesia,

                cerebras,

                cloudflare,

                customLlm,

                deepgram,

                deepinfra,

                deepSeek,

                elevenlabs,

                gcp,

                gladia,

                gohighlevel,

                google,

                groq,

                hume,

                inflectionAi,

                langfuse,

                lmnt,

                make,

                mistral,

                neuphonic,

                openai,

                openrouter,

                perplexityAi,

                playht,

                rimeAi,

                runpod,

                s3,

                smallestAi,

                speechmatics,

                soniox,

                supabase,

                tavus,

                togetherAi,

                trieve,

                twilio,

                vonage,

                webhook,

                customCredential,

                xai,

                googleCalendarOauth2Client,

                googleCalendarOauth2Authorization,

                googleSheetsOauth2Authorization,

                slackOauth2Authorization,

                ghlOauth2Authorization,

                inworld,

                minimax,

                wellsaid,

                email,

                slackWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CredentialsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAnthropicCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAnthropicCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAnthropicCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic!, typeInfo);
            }
            else if (value.IsAnthropicBedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAnthropicBedrockCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAnthropicBedrockCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAnthropicBedrockCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicBedrock!, typeInfo);
            }
            else if (value.IsAnyscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAnyscaleCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAnyscaleCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAnyscaleCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anyscale!, typeInfo);
            }
            else if (value.IsAssemblyAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAssemblyAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAssemblyAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAssemblyAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssemblyAi!, typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAzureCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAzureCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAzureCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure!, typeInfo);
            }
            else if (value.IsAzureOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAzureOpenAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAzureOpenAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateAzureOpenAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureOpenai!, typeInfo);
            }
            else if (value.IsByoSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateByoSipTrunkCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateByoSipTrunkCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateByoSipTrunkCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoSipTrunk!, typeInfo);
            }
            else if (value.IsCartesia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCartesiaCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCartesiaCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCartesiaCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cartesia!, typeInfo);
            }
            else if (value.IsCerebras)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCerebrasCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCerebrasCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCerebrasCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cerebras!, typeInfo);
            }
            else if (value.IsCloudflare)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCloudflareCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCloudflareCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCloudflareCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cloudflare!, typeInfo);
            }
            else if (value.IsCustomLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCustomLLMCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCustomLLMCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCustomLLMCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomLlm!, typeInfo);
            }
            else if (value.IsDeepgram)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDeepgramCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDeepgramCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateDeepgramCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepgram!, typeInfo);
            }
            else if (value.IsDeepinfra)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDeepInfraCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDeepInfraCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateDeepInfraCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepinfra!, typeInfo);
            }
            else if (value.IsDeepSeek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateDeepSeekCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateDeepSeekCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateDeepSeekCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeepSeek!, typeInfo);
            }
            else if (value.IsElevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateElevenLabsCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateElevenLabsCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateElevenLabsCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Elevenlabs!, typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGcpCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGcpCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGcpCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp!, typeInfo);
            }
            else if (value.IsGladia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGladiaCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGladiaCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGladiaCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gladia!, typeInfo);
            }
            else if (value.IsGohighlevel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoHighLevelCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gohighlevel!, typeInfo);
            }
            else if (value.IsGoogle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoogleCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google!, typeInfo);
            }
            else if (value.IsGroq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGroqCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGroqCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGroqCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq!, typeInfo);
            }
            else if (value.IsHume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateHumeCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateHumeCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateHumeCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Hume!, typeInfo);
            }
            else if (value.IsInflectionAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInflectionAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInflectionAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateInflectionAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InflectionAi!, typeInfo);
            }
            else if (value.IsLangfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLangfuseCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLangfuseCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateLangfuseCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langfuse!, typeInfo);
            }
            else if (value.IsLmnt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateLmntCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateLmntCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateLmntCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lmnt!, typeInfo);
            }
            else if (value.IsMake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMakeCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMakeCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateMakeCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Make!, typeInfo);
            }
            else if (value.IsMistral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMistralCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMistralCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateMistralCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mistral!, typeInfo);
            }
            else if (value.IsNeuphonic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateNeuphonicCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateNeuphonicCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateNeuphonicCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Neuphonic!, typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateOpenAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateOpenAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateOpenAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai!, typeInfo);
            }
            else if (value.IsOpenrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateOpenRouterCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateOpenRouterCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateOpenRouterCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openrouter!, typeInfo);
            }
            else if (value.IsPerplexityAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreatePerplexityAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreatePerplexityAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreatePerplexityAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PerplexityAi!, typeInfo);
            }
            else if (value.IsPlayht)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreatePlayHTCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreatePlayHTCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreatePlayHTCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Playht!, typeInfo);
            }
            else if (value.IsRimeAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateRimeAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateRimeAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateRimeAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RimeAi!, typeInfo);
            }
            else if (value.IsRunpod)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateRunpodCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateRunpodCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateRunpodCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Runpod!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateS3CredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateS3CredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateS3CredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsSmallestAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSmallestAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSmallestAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSmallestAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SmallestAi!, typeInfo);
            }
            else if (value.IsSpeechmatics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSpeechmaticsCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSpeechmaticsCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSpeechmaticsCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Speechmatics!, typeInfo);
            }
            else if (value.IsSoniox)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSonioxCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSonioxCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSonioxCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Soniox!, typeInfo);
            }
            else if (value.IsSupabase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSupabaseCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSupabaseCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSupabaseCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supabase!, typeInfo);
            }
            else if (value.IsTavus)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTavusCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTavusCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTavusCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tavus!, typeInfo);
            }
            else if (value.IsTogetherAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTogetherAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTogetherAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTogetherAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TogetherAi!, typeInfo);
            }
            else if (value.IsTrieve)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTrieveCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTrieveCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTrieveCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trieve!, typeInfo);
            }
            else if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTwilioCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTwilioCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTwilioCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio!, typeInfo);
            }
            else if (value.IsVonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVonageCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVonageCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateVonageCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage!, typeInfo);
            }
            else if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateWebhookCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateWebhookCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateWebhookCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
            else if (value.IsCustomCredential)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCustomCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCustomCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCustomCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomCredential!, typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateXAiCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateXAiCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateXAiCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai!, typeInfo);
            }
            else if (value.IsGoogleCalendarOauth2Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarOauth2Client!, typeInfo);
            }
            else if (value.IsGoogleCalendarOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarOauth2Authorization!, typeInfo);
            }
            else if (value.IsGoogleSheetsOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsOauth2Authorization!, typeInfo);
            }
            else if (value.IsSlackOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSlackOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSlackOAuth2AuthorizationCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSlackOAuth2AuthorizationCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackOauth2Authorization!, typeInfo);
            }
            else if (value.IsGhlOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateGoHighLevelMCPCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateGoHighLevelMCPCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateGoHighLevelMCPCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GhlOauth2Authorization!, typeInfo);
            }
            else if (value.IsInworld)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateInworldCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateInworldCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateInworldCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inworld!, typeInfo);
            }
            else if (value.IsMinimax)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateMinimaxCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateMinimaxCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateMinimaxCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Minimax!, typeInfo);
            }
            else if (value.IsWellsaid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateWellSaidCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateWellSaidCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateWellSaidCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wellsaid!, typeInfo);
            }
            else if (value.IsEmail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateEmailCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateEmailCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateEmailCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Email!, typeInfo);
            }
            else if (value.IsSlackWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSlackWebhookCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSlackWebhookCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSlackWebhookCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackWebhook!, typeInfo);
            }
        }
    }
}