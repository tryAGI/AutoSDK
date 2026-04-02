//HintName: G.JsonConverters.EmbeddingConfig2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingConfig2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingConfig2>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingConfig2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator>(ref readerCopy, options);

            global::G.AzureOpenAIEmbeddingConfig? azureEmbedding1 = default;
            if (discriminator?.Type == global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.AzureEmbedding)
            {
                azureEmbedding1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AzureOpenAIEmbeddingConfig>(ref reader, options);
            }
            global::G.CohereEmbeddingConfig? cohereEmbedding = default;
            if (discriminator?.Type == global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.CohereEmbedding)
            {
                cohereEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CohereEmbeddingConfig>(ref reader, options);
            }
            global::G.GeminiEmbeddingConfig? geminiEmbedding = default;
            if (discriminator?.Type == global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.GeminiEmbedding)
            {
                geminiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GeminiEmbeddingConfig>(ref reader, options);
            }
            global::G.HuggingFaceInferenceAPIEmbeddingConfig? huggingfaceApiEmbedding = default;
            if (discriminator?.Type == global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.HuggingfaceApiEmbedding)
            {
                huggingfaceApiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HuggingFaceInferenceAPIEmbeddingConfig>(ref reader, options);
            }
            global::G.OpenAIEmbeddingConfig? azureEmbedding2 = default;
            if (discriminator?.Type == global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.AzureEmbedding)
            {
                azureEmbedding2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OpenAIEmbeddingConfig>(ref reader, options);
            }
            global::G.VertexAIEmbeddingConfig? vertexaiEmbedding = default;
            if (discriminator?.Type == global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.VertexaiEmbedding)
            {
                vertexaiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VertexAIEmbeddingConfig>(ref reader, options);
            }
            global::G.BedrockEmbeddingConfig? bedrockEmbedding = default;
            if (discriminator?.Type == global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.BedrockEmbedding)
            {
                bedrockEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BedrockEmbeddingConfig>(ref reader, options);
            }

            var __value = new global::G.EmbeddingConfig2(
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
            global::G.EmbeddingConfig2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAzureEmbedding1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEmbedding1, typeof(global::G.AzureOpenAIEmbeddingConfig), options);
            }
            else if (value.IsCohereEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CohereEmbedding, typeof(global::G.CohereEmbeddingConfig), options);
            }
            else if (value.IsGeminiEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeminiEmbedding, typeof(global::G.GeminiEmbeddingConfig), options);
            }
            else if (value.IsHuggingfaceApiEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HuggingfaceApiEmbedding, typeof(global::G.HuggingFaceInferenceAPIEmbeddingConfig), options);
            }
            else if (value.IsAzureEmbedding2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEmbedding2, typeof(global::G.OpenAIEmbeddingConfig), options);
            }
            else if (value.IsVertexaiEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexaiEmbedding, typeof(global::G.VertexAIEmbeddingConfig), options);
            }
            else if (value.IsBedrockEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockEmbedding, typeof(global::G.BedrockEmbeddingConfig), options);
            }
        }
    }
}