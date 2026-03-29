//HintName: G.Models.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureEmbedding,
        /// <summary>
        /// 
        /// </summary>
        BedrockEmbedding,
        /// <summary>
        /// 
        /// </summary>
        CohereEmbedding,
        /// <summary>
        /// 
        /// </summary>
        GeminiEmbedding,
        /// <summary>
        /// 
        /// </summary>
        HuggingfaceApiEmbedding,
        /// <summary>
        /// 
        /// </summary>
        OpenaiEmbedding,
        /// <summary>
        /// 
        /// </summary>
        VertexaiEmbedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType value)
        {
            return value switch
            {
                EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.AzureEmbedding => "AZURE_EMBEDDING",
                EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.BedrockEmbedding => "BEDROCK_EMBEDDING",
                EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.CohereEmbedding => "COHERE_EMBEDDING",
                EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.GeminiEmbedding => "GEMINI_EMBEDDING",
                EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.HuggingfaceApiEmbedding => "HUGGINGFACE_API_EMBEDDING",
                EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.OpenaiEmbedding => "OPENAI_EMBEDDING",
                EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.VertexaiEmbedding => "VERTEXAI_EMBEDDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_EMBEDDING" => EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.AzureEmbedding,
                "BEDROCK_EMBEDDING" => EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.BedrockEmbedding,
                "COHERE_EMBEDDING" => EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.CohereEmbedding,
                "GEMINI_EMBEDDING" => EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.GeminiEmbedding,
                "HUGGINGFACE_API_EMBEDDING" => EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.HuggingfaceApiEmbedding,
                "OPENAI_EMBEDDING" => EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.OpenaiEmbedding,
                "VERTEXAI_EMBEDDING" => EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.VertexaiEmbedding,
                _ => null,
            };
        }
    }
}