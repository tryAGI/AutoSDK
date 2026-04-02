//HintName: G.JsonConverters.CredentialsItem5.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CredentialsItem5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CredentialsItem5>
    {
        /// <inheritdoc />
        public override global::G.CredentialsItem5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateAssistantDTOCredentialDiscriminator>(ref readerCopy, options);

            global::G.CreateAnthropicCredentialDTO? anthropic = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Anthropic)
            {
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateAnthropicCredentialDTO>(ref reader, options);
            }
            global::G.CreateAnthropicBedrockCredentialDTO? anthropicBedrock = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.AnthropicBedrock)
            {
                anthropicBedrock = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateAnthropicBedrockCredentialDTO>(ref reader, options);
            }
            global::G.CreateAnyscaleCredentialDTO? anyscale = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Anyscale)
            {
                anyscale = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateAnyscaleCredentialDTO>(ref reader, options);
            }
            global::G.CreateAssemblyAICredentialDTO? assemblyAi = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.AssemblyAi)
            {
                assemblyAi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateAssemblyAICredentialDTO>(ref reader, options);
            }
            global::G.CreateAzureCredentialDTO? azure = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Azure)
            {
                azure = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateAzureCredentialDTO>(ref reader, options);
            }
            global::G.CreateAzureOpenAICredentialDTO? azureOpenai = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.AzureOpenai)
            {
                azureOpenai = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateAzureOpenAICredentialDTO>(ref reader, options);
            }
            global::G.CreateByoSipTrunkCredentialDTO? byoSipTrunk = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.ByoSipTrunk)
            {
                byoSipTrunk = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateByoSipTrunkCredentialDTO>(ref reader, options);
            }
            global::G.CreateCartesiaCredentialDTO? cartesia = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Cartesia)
            {
                cartesia = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCartesiaCredentialDTO>(ref reader, options);
            }
            global::G.CreateCerebrasCredentialDTO? cerebras = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Cerebras)
            {
                cerebras = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCerebrasCredentialDTO>(ref reader, options);
            }
            global::G.CreateCloudflareCredentialDTO? cloudflare = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Cloudflare)
            {
                cloudflare = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCloudflareCredentialDTO>(ref reader, options);
            }
            global::G.CreateCustomLLMCredentialDTO? customLlm = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.CustomLlm)
            {
                customLlm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCustomLLMCredentialDTO>(ref reader, options);
            }
            global::G.CreateDeepgramCredentialDTO? deepgram = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Deepgram)
            {
                deepgram = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateDeepgramCredentialDTO>(ref reader, options);
            }
            global::G.CreateDeepInfraCredentialDTO? deepinfra = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Deepinfra)
            {
                deepinfra = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateDeepInfraCredentialDTO>(ref reader, options);
            }
            global::G.CreateDeepSeekCredentialDTO? deepSeek = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.DeepSeek)
            {
                deepSeek = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateDeepSeekCredentialDTO>(ref reader, options);
            }
            global::G.CreateElevenLabsCredentialDTO? elevenlabs = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Elevenlabs)
            {
                elevenlabs = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateElevenLabsCredentialDTO>(ref reader, options);
            }
            global::G.CreateGcpCredentialDTO? gcp = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Gcp)
            {
                gcp = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGcpCredentialDTO>(ref reader, options);
            }
            global::G.CreateGladiaCredentialDTO? gladia = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Gladia)
            {
                gladia = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGladiaCredentialDTO>(ref reader, options);
            }
            global::G.CreateGoHighLevelCredentialDTO? gohighlevel = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Gohighlevel)
            {
                gohighlevel = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoHighLevelCredentialDTO>(ref reader, options);
            }
            global::G.CreateGoogleCredentialDTO? google = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Google)
            {
                google = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoogleCredentialDTO>(ref reader, options);
            }
            global::G.CreateGroqCredentialDTO? groq = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Groq)
            {
                groq = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGroqCredentialDTO>(ref reader, options);
            }
            global::G.CreateHumeCredentialDTO? hume = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Hume)
            {
                hume = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateHumeCredentialDTO>(ref reader, options);
            }
            global::G.CreateInflectionAICredentialDTO? inflectionAi = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.InflectionAi)
            {
                inflectionAi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateInflectionAICredentialDTO>(ref reader, options);
            }
            global::G.CreateLangfuseCredentialDTO? langfuse = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Langfuse)
            {
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateLangfuseCredentialDTO>(ref reader, options);
            }
            global::G.CreateLmntCredentialDTO? lmnt = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Lmnt)
            {
                lmnt = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateLmntCredentialDTO>(ref reader, options);
            }
            global::G.CreateMakeCredentialDTO? make = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Make)
            {
                make = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateMakeCredentialDTO>(ref reader, options);
            }
            global::G.CreateMistralCredentialDTO? mistral = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Mistral)
            {
                mistral = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateMistralCredentialDTO>(ref reader, options);
            }
            global::G.CreateNeuphonicCredentialDTO? neuphonic = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Neuphonic)
            {
                neuphonic = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateNeuphonicCredentialDTO>(ref reader, options);
            }
            global::G.CreateOpenAICredentialDTO? openai = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Openai)
            {
                openai = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateOpenAICredentialDTO>(ref reader, options);
            }
            global::G.CreateOpenRouterCredentialDTO? openrouter = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Openrouter)
            {
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateOpenRouterCredentialDTO>(ref reader, options);
            }
            global::G.CreatePerplexityAICredentialDTO? perplexityAi = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.PerplexityAi)
            {
                perplexityAi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreatePerplexityAICredentialDTO>(ref reader, options);
            }
            global::G.CreatePlayHTCredentialDTO? playht = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Playht)
            {
                playht = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreatePlayHTCredentialDTO>(ref reader, options);
            }
            global::G.CreateRimeAICredentialDTO? rimeAi = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.RimeAi)
            {
                rimeAi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateRimeAICredentialDTO>(ref reader, options);
            }
            global::G.CreateRunpodCredentialDTO? runpod = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Runpod)
            {
                runpod = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateRunpodCredentialDTO>(ref reader, options);
            }
            global::G.CreateS3CredentialDTO? s3 = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.S3)
            {
                s3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateS3CredentialDTO>(ref reader, options);
            }
            global::G.CreateSmallestAICredentialDTO? smallestAi = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.SmallestAi)
            {
                smallestAi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSmallestAICredentialDTO>(ref reader, options);
            }
            global::G.CreateSpeechmaticsCredentialDTO? speechmatics = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Speechmatics)
            {
                speechmatics = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSpeechmaticsCredentialDTO>(ref reader, options);
            }
            global::G.CreateSonioxCredentialDTO? soniox = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Soniox)
            {
                soniox = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSonioxCredentialDTO>(ref reader, options);
            }
            global::G.CreateSupabaseCredentialDTO? supabase = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Supabase)
            {
                supabase = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSupabaseCredentialDTO>(ref reader, options);
            }
            global::G.CreateTavusCredentialDTO? tavus = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Tavus)
            {
                tavus = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTavusCredentialDTO>(ref reader, options);
            }
            global::G.CreateTogetherAICredentialDTO? togetherAi = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.TogetherAi)
            {
                togetherAi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTogetherAICredentialDTO>(ref reader, options);
            }
            global::G.CreateTrieveCredentialDTO? trieve = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Trieve)
            {
                trieve = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTrieveCredentialDTO>(ref reader, options);
            }
            global::G.CreateTwilioCredentialDTO? twilio = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTwilioCredentialDTO>(ref reader, options);
            }
            global::G.CreateVonageCredentialDTO? vonage = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Vonage)
            {
                vonage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateVonageCredentialDTO>(ref reader, options);
            }
            global::G.CreateWebhookCredentialDTO? webhook = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateWebhookCredentialDTO>(ref reader, options);
            }
            global::G.CreateCustomCredentialDTO? customCredential = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.CustomCredential)
            {
                customCredential = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCustomCredentialDTO>(ref reader, options);
            }
            global::G.CreateXAiCredentialDTO? xai = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Xai)
            {
                xai = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateXAiCredentialDTO>(ref reader, options);
            }
            global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO? googleCalendarOauth2Client = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client)
            {
                googleCalendarOauth2Client = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO>(ref reader, options);
            }
            global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? googleCalendarOauth2Authorization = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization)
            {
                googleCalendarOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO>(ref reader, options);
            }
            global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? googleSheetsOauth2Authorization = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization)
            {
                googleSheetsOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO>(ref reader, options);
            }
            global::G.CreateSlackOAuth2AuthorizationCredentialDTO? slackOauth2Authorization = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.SlackOauth2Authorization)
            {
                slackOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSlackOAuth2AuthorizationCredentialDTO>(ref reader, options);
            }
            global::G.CreateGoHighLevelMCPCredentialDTO? ghlOauth2Authorization = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.GhlOauth2Authorization)
            {
                ghlOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateGoHighLevelMCPCredentialDTO>(ref reader, options);
            }
            global::G.CreateInworldCredentialDTO? inworld = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Inworld)
            {
                inworld = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateInworldCredentialDTO>(ref reader, options);
            }
            global::G.CreateMinimaxCredentialDTO? minimax = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Minimax)
            {
                minimax = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateMinimaxCredentialDTO>(ref reader, options);
            }
            global::G.CreateWellSaidCredentialDTO? wellsaid = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Wellsaid)
            {
                wellsaid = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateWellSaidCredentialDTO>(ref reader, options);
            }
            global::G.CreateEmailCredentialDTO? email = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.Email)
            {
                email = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateEmailCredentialDTO>(ref reader, options);
            }
            global::G.CreateSlackWebhookCredentialDTO? slackWebhook = default;
            if (discriminator?.Provider == global::G.UpdateAssistantDTOCredentialDiscriminatorProvider.SlackWebhook)
            {
                slackWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateSlackWebhookCredentialDTO>(ref reader, options);
            }

            var __value = new global::G.CredentialsItem5(
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
            global::G.CredentialsItem5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAnthropic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic, typeof(global::G.CreateAnthropicCredentialDTO), options);
            }
            else if (value.IsAnthropicBedrock)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicBedrock, typeof(global::G.CreateAnthropicBedrockCredentialDTO), options);
            }
            else if (value.IsAnyscale)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anyscale, typeof(global::G.CreateAnyscaleCredentialDTO), options);
            }
            else if (value.IsAssemblyAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssemblyAi, typeof(global::G.CreateAssemblyAICredentialDTO), options);
            }
            else if (value.IsAzure)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure, typeof(global::G.CreateAzureCredentialDTO), options);
            }
            else if (value.IsAzureOpenai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureOpenai, typeof(global::G.CreateAzureOpenAICredentialDTO), options);
            }
            else if (value.IsByoSipTrunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoSipTrunk, typeof(global::G.CreateByoSipTrunkCredentialDTO), options);
            }
            else if (value.IsCartesia)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cartesia, typeof(global::G.CreateCartesiaCredentialDTO), options);
            }
            else if (value.IsCerebras)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cerebras, typeof(global::G.CreateCerebrasCredentialDTO), options);
            }
            else if (value.IsCloudflare)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cloudflare, typeof(global::G.CreateCloudflareCredentialDTO), options);
            }
            else if (value.IsCustomLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomLlm, typeof(global::G.CreateCustomLLMCredentialDTO), options);
            }
            else if (value.IsDeepgram)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepgram, typeof(global::G.CreateDeepgramCredentialDTO), options);
            }
            else if (value.IsDeepinfra)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepinfra, typeof(global::G.CreateDeepInfraCredentialDTO), options);
            }
            else if (value.IsDeepSeek)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeepSeek, typeof(global::G.CreateDeepSeekCredentialDTO), options);
            }
            else if (value.IsElevenlabs)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Elevenlabs, typeof(global::G.CreateElevenLabsCredentialDTO), options);
            }
            else if (value.IsGcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp, typeof(global::G.CreateGcpCredentialDTO), options);
            }
            else if (value.IsGladia)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gladia, typeof(global::G.CreateGladiaCredentialDTO), options);
            }
            else if (value.IsGohighlevel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gohighlevel, typeof(global::G.CreateGoHighLevelCredentialDTO), options);
            }
            else if (value.IsGoogle)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google, typeof(global::G.CreateGoogleCredentialDTO), options);
            }
            else if (value.IsGroq)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq, typeof(global::G.CreateGroqCredentialDTO), options);
            }
            else if (value.IsHume)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Hume, typeof(global::G.CreateHumeCredentialDTO), options);
            }
            else if (value.IsInflectionAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InflectionAi, typeof(global::G.CreateInflectionAICredentialDTO), options);
            }
            else if (value.IsLangfuse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langfuse, typeof(global::G.CreateLangfuseCredentialDTO), options);
            }
            else if (value.IsLmnt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lmnt, typeof(global::G.CreateLmntCredentialDTO), options);
            }
            else if (value.IsMake)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Make, typeof(global::G.CreateMakeCredentialDTO), options);
            }
            else if (value.IsMistral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mistral, typeof(global::G.CreateMistralCredentialDTO), options);
            }
            else if (value.IsNeuphonic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Neuphonic, typeof(global::G.CreateNeuphonicCredentialDTO), options);
            }
            else if (value.IsOpenai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai, typeof(global::G.CreateOpenAICredentialDTO), options);
            }
            else if (value.IsOpenrouter)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openrouter, typeof(global::G.CreateOpenRouterCredentialDTO), options);
            }
            else if (value.IsPerplexityAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PerplexityAi, typeof(global::G.CreatePerplexityAICredentialDTO), options);
            }
            else if (value.IsPlayht)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Playht, typeof(global::G.CreatePlayHTCredentialDTO), options);
            }
            else if (value.IsRimeAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RimeAi, typeof(global::G.CreateRimeAICredentialDTO), options);
            }
            else if (value.IsRunpod)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Runpod, typeof(global::G.CreateRunpodCredentialDTO), options);
            }
            else if (value.IsS3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3, typeof(global::G.CreateS3CredentialDTO), options);
            }
            else if (value.IsSmallestAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SmallestAi, typeof(global::G.CreateSmallestAICredentialDTO), options);
            }
            else if (value.IsSpeechmatics)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Speechmatics, typeof(global::G.CreateSpeechmaticsCredentialDTO), options);
            }
            else if (value.IsSoniox)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Soniox, typeof(global::G.CreateSonioxCredentialDTO), options);
            }
            else if (value.IsSupabase)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supabase, typeof(global::G.CreateSupabaseCredentialDTO), options);
            }
            else if (value.IsTavus)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tavus, typeof(global::G.CreateTavusCredentialDTO), options);
            }
            else if (value.IsTogetherAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TogetherAi, typeof(global::G.CreateTogetherAICredentialDTO), options);
            }
            else if (value.IsTrieve)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trieve, typeof(global::G.CreateTrieveCredentialDTO), options);
            }
            else if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::G.CreateTwilioCredentialDTO), options);
            }
            else if (value.IsVonage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeof(global::G.CreateVonageCredentialDTO), options);
            }
            else if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::G.CreateWebhookCredentialDTO), options);
            }
            else if (value.IsCustomCredential)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomCredential, typeof(global::G.CreateCustomCredentialDTO), options);
            }
            else if (value.IsXai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai, typeof(global::G.CreateXAiCredentialDTO), options);
            }
            else if (value.IsGoogleCalendarOauth2Client)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarOauth2Client, typeof(global::G.CreateGoogleCalendarOAuth2ClientCredentialDTO), options);
            }
            else if (value.IsGoogleCalendarOauth2Authorization)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarOauth2Authorization, typeof(global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO), options);
            }
            else if (value.IsGoogleSheetsOauth2Authorization)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsOauth2Authorization, typeof(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO), options);
            }
            else if (value.IsSlackOauth2Authorization)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackOauth2Authorization, typeof(global::G.CreateSlackOAuth2AuthorizationCredentialDTO), options);
            }
            else if (value.IsGhlOauth2Authorization)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GhlOauth2Authorization, typeof(global::G.CreateGoHighLevelMCPCredentialDTO), options);
            }
            else if (value.IsInworld)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inworld, typeof(global::G.CreateInworldCredentialDTO), options);
            }
            else if (value.IsMinimax)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Minimax, typeof(global::G.CreateMinimaxCredentialDTO), options);
            }
            else if (value.IsWellsaid)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wellsaid, typeof(global::G.CreateWellSaidCredentialDTO), options);
            }
            else if (value.IsEmail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Email, typeof(global::G.CreateEmailCredentialDTO), options);
            }
            else if (value.IsSlackWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackWebhook, typeof(global::G.CreateSlackWebhookCredentialDTO), options);
            }
        }
    }
}