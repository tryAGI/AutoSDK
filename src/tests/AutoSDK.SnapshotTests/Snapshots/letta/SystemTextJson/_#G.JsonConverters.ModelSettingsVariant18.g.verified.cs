//HintName: G.JsonConverters.ModelSettingsVariant18.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ModelSettingsVariant18JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModelSettingsVariant18>
    {
        /// <inheritdoc />
        public override global::G.ModelSettingsVariant18 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateAgentModelSettingsVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateAgentModelSettingsVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateAgentModelSettingsVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.OpenAIModelSettings? openai = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAIModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OpenAIModelSettings)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AnthropicModelSettings? anthropic = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AnthropicModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AnthropicModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AnthropicModelSettings)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoogleAIModelSettings? googleAi = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.GoogleAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleAIModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoogleAIModelSettings)}");
                googleAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GoogleVertexModelSettings? googleVertex = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.GoogleVertex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleVertexModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleVertexModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GoogleVertexModelSettings)}");
                googleVertex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AzureModelSettings? azure = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AzureModelSettings)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.XAIModelSettings? xai = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.XAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.XAIModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.XAIModelSettings)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ZAIModelSettings? zai = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Zai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ZAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ZAIModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ZAIModelSettings)}");
                zai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GroqModelSettings? groq = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Groq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GroqModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GroqModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GroqModelSettings)}");
                groq = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.DeepseekModelSettings? deepseek = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Deepseek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeepseekModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeepseekModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DeepseekModelSettings)}");
                deepseek = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TogetherModelSettings? together = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Together)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TogetherModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TogetherModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TogetherModelSettings)}");
                together = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BedrockModelSettings? bedrock = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Bedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BedrockModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BedrockModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BedrockModelSettings)}");
                bedrock = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OpenRouterModelSettings? openrouter = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Openrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenRouterModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenRouterModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OpenRouterModelSettings)}");
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChatGPTOAuthModelSettings? chatgptOauth = default;
            if (discriminator?.ProviderType == global::G.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatGPTOAuthModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatGPTOAuthModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatGPTOAuthModelSettings)}");
                chatgptOauth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ModelSettingsVariant18(
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
            global::G.ModelSettingsVariant18 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAIModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAIModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai!, typeInfo);
            }
            else if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AnthropicModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AnthropicModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AnthropicModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic!, typeInfo);
            }
            else if (value.IsGoogleAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleAIModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleAIModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleAi!, typeInfo);
            }
            else if (value.IsGoogleVertex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GoogleVertexModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GoogleVertexModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GoogleVertexModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertex!, typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure!, typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.XAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.XAIModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.XAIModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai!, typeInfo);
            }
            else if (value.IsZai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ZAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ZAIModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ZAIModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zai!, typeInfo);
            }
            else if (value.IsGroq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GroqModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GroqModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GroqModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq!, typeInfo);
            }
            else if (value.IsDeepseek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DeepseekModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DeepseekModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DeepseekModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepseek!, typeInfo);
            }
            else if (value.IsTogether)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TogetherModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TogetherModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TogetherModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Together!, typeInfo);
            }
            else if (value.IsBedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BedrockModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BedrockModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BedrockModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bedrock!, typeInfo);
            }
            else if (value.IsOpenrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenRouterModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenRouterModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenRouterModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openrouter!, typeInfo);
            }
            else if (value.IsChatgptOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatGPTOAuthModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatGPTOAuthModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatGPTOAuthModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatgptOauth!, typeInfo);
            }
        }
    }
}