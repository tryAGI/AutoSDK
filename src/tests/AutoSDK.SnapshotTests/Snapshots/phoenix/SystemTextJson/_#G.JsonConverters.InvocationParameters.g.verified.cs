//HintName: G.JsonConverters.InvocationParameters.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InvocationParametersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InvocationParameters>
    {
        /// <inheritdoc />
        public override global::G.InvocationParameters Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptVersionInvocationParametersDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptVersionInvocationParametersDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptVersionInvocationParametersDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PromptOpenAIInvocationParameters? openai = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptOpenAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptOpenAIInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptOpenAIInvocationParameters)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptAzureOpenAIInvocationParameters? azureOpenai = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.AzureOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAzureOpenAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAzureOpenAIInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAzureOpenAIInvocationParameters)}");
                azureOpenai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptAnthropicInvocationParameters? anthropic = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAnthropicInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAnthropicInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAnthropicInvocationParameters)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptGoogleInvocationParameters? google = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Google)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptGoogleInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptGoogleInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptGoogleInvocationParameters)}");
                google = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptDeepSeekInvocationParameters? deepseek = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Deepseek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptDeepSeekInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptDeepSeekInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptDeepSeekInvocationParameters)}");
                deepseek = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptXAIInvocationParameters? xai = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptXAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptXAIInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptXAIInvocationParameters)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptOllamaInvocationParameters? ollama = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Ollama)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptOllamaInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptOllamaInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptOllamaInvocationParameters)}");
                ollama = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptAwsInvocationParameters? aws = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAwsInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAwsInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptAwsInvocationParameters)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptCerebrasInvocationParameters? cerebras = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Cerebras)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptCerebrasInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptCerebrasInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptCerebrasInvocationParameters)}");
                cerebras = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptFireworksInvocationParameters? fireworks = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Fireworks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptFireworksInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptFireworksInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptFireworksInvocationParameters)}");
                fireworks = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptGroqInvocationParameters? groq = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Groq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptGroqInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptGroqInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptGroqInvocationParameters)}");
                groq = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptMoonshotInvocationParameters? moonshot = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Moonshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptMoonshotInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptMoonshotInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptMoonshotInvocationParameters)}");
                moonshot = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptPerplexityInvocationParameters? perplexity = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Perplexity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptPerplexityInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptPerplexityInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptPerplexityInvocationParameters)}");
                perplexity = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PromptTogetherInvocationParameters? together = default;
            if (discriminator?.Type == global::G.PromptVersionInvocationParametersDiscriminatorType.Together)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptTogetherInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptTogetherInvocationParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PromptTogetherInvocationParameters)}");
                together = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.InvocationParameters(
                discriminator?.Type,
                openai,

                azureOpenai,

                anthropic,

                google,

                deepseek,

                xai,

                ollama,

                aws,

                cerebras,

                fireworks,

                groq,

                moonshot,

                perplexity,

                together
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InvocationParameters value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptOpenAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptOpenAIInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptOpenAIInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai, typeInfo);
            }
            else if (value.IsAzureOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAzureOpenAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAzureOpenAIInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptAzureOpenAIInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureOpenai, typeInfo);
            }
            else if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAnthropicInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAnthropicInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptAnthropicInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic, typeInfo);
            }
            else if (value.IsGoogle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptGoogleInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptGoogleInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptGoogleInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google, typeInfo);
            }
            else if (value.IsDeepseek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptDeepSeekInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptDeepSeekInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptDeepSeekInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepseek, typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptXAIInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptXAIInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptXAIInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai, typeInfo);
            }
            else if (value.IsOllama)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptOllamaInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptOllamaInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptOllamaInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ollama, typeInfo);
            }
            else if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptAwsInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptAwsInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptAwsInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Aws, typeInfo);
            }
            else if (value.IsCerebras)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptCerebrasInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptCerebrasInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptCerebrasInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cerebras, typeInfo);
            }
            else if (value.IsFireworks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptFireworksInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptFireworksInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptFireworksInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fireworks, typeInfo);
            }
            else if (value.IsGroq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptGroqInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptGroqInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptGroqInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq, typeInfo);
            }
            else if (value.IsMoonshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptMoonshotInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptMoonshotInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptMoonshotInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Moonshot, typeInfo);
            }
            else if (value.IsPerplexity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptPerplexityInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptPerplexityInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptPerplexityInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Perplexity, typeInfo);
            }
            else if (value.IsTogether)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PromptTogetherInvocationParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PromptTogetherInvocationParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PromptTogetherInvocationParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Together, typeInfo);
            }
        }
    }
}