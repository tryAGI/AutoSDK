//HintName: G.JsonConverters.EmbeddingConfigVariant13.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingConfigVariant13JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingConfigVariant13>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingConfigVariant13 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PipelineUpdateEmbeddingConfigVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PipelineUpdateEmbeddingConfigVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PipelineUpdateEmbeddingConfigVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.AzureOpenAIEmbeddingConfig? azureEmbedding1 = default;
            if (discriminator?.Type == global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureOpenAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureOpenAIEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AzureOpenAIEmbeddingConfig)}");
                azureEmbedding1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CohereEmbeddingConfig? cohereEmbedding = default;
            if (discriminator?.Type == global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CohereEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CohereEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CohereEmbeddingConfig)}");
                cohereEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GeminiEmbeddingConfig? geminiEmbedding = default;
            if (discriminator?.Type == global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeminiEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeminiEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GeminiEmbeddingConfig)}");
                geminiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HuggingFaceInferenceAPIEmbeddingConfig? huggingfaceApiEmbedding = default;
            if (discriminator?.Type == global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HuggingFaceInferenceAPIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HuggingFaceInferenceAPIEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HuggingFaceInferenceAPIEmbeddingConfig)}");
                huggingfaceApiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OpenAIEmbeddingConfig? azureEmbedding2 = default;
            if (discriminator?.Type == global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAIEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OpenAIEmbeddingConfig)}");
                azureEmbedding2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VertexAIEmbeddingConfig? vertexaiEmbedding = default;
            if (discriminator?.Type == global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAIEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VertexAIEmbeddingConfig)}");
                vertexaiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BedrockEmbeddingConfig? bedrockEmbedding = default;
            if (discriminator?.Type == global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BedrockEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BedrockEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BedrockEmbeddingConfig)}");
                bedrockEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.EmbeddingConfigVariant13(
                discriminator?.Type,
                azureEmbedding1,

                cohereEmbedding,

                geminiEmbedding,

                huggingfaceApiEmbedding,

                azureEmbedding2,

                vertexaiEmbedding,

                bedrockEmbedding
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingConfigVariant13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAzureEmbedding1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureOpenAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureOpenAIEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureOpenAIEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEmbedding1!, typeInfo);
            }
            else if (value.IsCohereEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CohereEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CohereEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CohereEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CohereEmbedding!, typeInfo);
            }
            else if (value.IsGeminiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeminiEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeminiEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GeminiEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeminiEmbedding!, typeInfo);
            }
            else if (value.IsHuggingfaceApiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HuggingFaceInferenceAPIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HuggingFaceInferenceAPIEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HuggingFaceInferenceAPIEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HuggingfaceApiEmbedding!, typeInfo);
            }
            else if (value.IsAzureEmbedding2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAIEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAIEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEmbedding2!, typeInfo);
            }
            else if (value.IsVertexaiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VertexAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VertexAIEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VertexAIEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexaiEmbedding!, typeInfo);
            }
            else if (value.IsBedrockEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BedrockEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BedrockEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BedrockEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockEmbedding!, typeInfo);
            }
        }
    }
}