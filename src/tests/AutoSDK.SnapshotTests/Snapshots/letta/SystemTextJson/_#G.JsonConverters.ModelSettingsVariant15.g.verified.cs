//HintName: G.JsonConverters.ModelSettingsVariant15.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ModelSettingsVariant15JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModelSettingsVariant15>
    {
        /// <inheritdoc />
        public override global::G.ModelSettingsVariant15 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateAgentRequestModelSettingsVariant1Discriminator>(ref readerCopy, options);

            global::G.OpenAIModelSettings? openai = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Openai)
            {
                openai = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OpenAIModelSettings>(ref reader, options);
            }
            global::G.AnthropicModelSettings? anthropic = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Anthropic)
            {
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnthropicModelSettings>(ref reader, options);
            }
            global::G.GoogleAIModelSettings? googleAi = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.GoogleAi)
            {
                googleAi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoogleAIModelSettings>(ref reader, options);
            }
            global::G.GoogleVertexModelSettings? googleVertex = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.GoogleVertex)
            {
                googleVertex = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GoogleVertexModelSettings>(ref reader, options);
            }
            global::G.AzureModelSettings? azure = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Azure)
            {
                azure = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AzureModelSettings>(ref reader, options);
            }
            global::G.XAIModelSettings? xai = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Xai)
            {
                xai = global::System.Text.Json.JsonSerializer.Deserialize<global::G.XAIModelSettings>(ref reader, options);
            }
            global::G.ZAIModelSettings? zai = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Zai)
            {
                zai = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ZAIModelSettings>(ref reader, options);
            }
            global::G.GroqModelSettings? groq = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Groq)
            {
                groq = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GroqModelSettings>(ref reader, options);
            }
            global::G.DeepseekModelSettings? deepseek = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Deepseek)
            {
                deepseek = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeepseekModelSettings>(ref reader, options);
            }
            global::G.TogetherModelSettings? together = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Together)
            {
                together = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TogetherModelSettings>(ref reader, options);
            }
            global::G.BedrockModelSettings? bedrock = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Bedrock)
            {
                bedrock = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BedrockModelSettings>(ref reader, options);
            }
            global::G.OpenRouterModelSettings? openrouter = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Openrouter)
            {
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OpenRouterModelSettings>(ref reader, options);
            }
            global::G.ChatGPTOAuthModelSettings? chatgptOauth = default;
            if (discriminator?.ProviderType == global::G.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth)
            {
                chatgptOauth = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatGPTOAuthModelSettings>(ref reader, options);
            }

            var __value = new global::G.ModelSettingsVariant15(
                discriminator?.ProviderType,
                openai,

                anthropic,

                googleAi,

                googleVertex,

                azure,

                xai,

                zai,

                groq,

                deepseek,

                together,

                bedrock,

                openrouter,

                chatgptOauth
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ModelSettingsVariant15 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOpenai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai, typeof(global::G.OpenAIModelSettings), options);
            }
            else if (value.IsAnthropic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic, typeof(global::G.AnthropicModelSettings), options);
            }
            else if (value.IsGoogleAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleAi, typeof(global::G.GoogleAIModelSettings), options);
            }
            else if (value.IsGoogleVertex)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertex, typeof(global::G.GoogleVertexModelSettings), options);
            }
            else if (value.IsAzure)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure, typeof(global::G.AzureModelSettings), options);
            }
            else if (value.IsXai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai, typeof(global::G.XAIModelSettings), options);
            }
            else if (value.IsZai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zai, typeof(global::G.ZAIModelSettings), options);
            }
            else if (value.IsGroq)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq, typeof(global::G.GroqModelSettings), options);
            }
            else if (value.IsDeepseek)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepseek, typeof(global::G.DeepseekModelSettings), options);
            }
            else if (value.IsTogether)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Together, typeof(global::G.TogetherModelSettings), options);
            }
            else if (value.IsBedrock)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bedrock, typeof(global::G.BedrockModelSettings), options);
            }
            else if (value.IsOpenrouter)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openrouter, typeof(global::G.OpenRouterModelSettings), options);
            }
            else if (value.IsChatgptOauth)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatgptOauth, typeof(global::G.ChatGPTOAuthModelSettings), options);
            }
        }
    }
}