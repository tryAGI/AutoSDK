//HintName: G.Models.EmbeddingModelConfigEmbeddingConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingModelConfigEmbeddingConfigDiscriminatorType
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
    public static class EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingModelConfigEmbeddingConfigDiscriminatorType value)
        {
            return value switch
            {
                EmbeddingModelConfigEmbeddingConfigDiscriminatorType.AzureEmbedding => "AZURE_EMBEDDING",
                EmbeddingModelConfigEmbeddingConfigDiscriminatorType.BedrockEmbedding => "BEDROCK_EMBEDDING",
                EmbeddingModelConfigEmbeddingConfigDiscriminatorType.CohereEmbedding => "COHERE_EMBEDDING",
                EmbeddingModelConfigEmbeddingConfigDiscriminatorType.GeminiEmbedding => "GEMINI_EMBEDDING",
                EmbeddingModelConfigEmbeddingConfigDiscriminatorType.HuggingfaceApiEmbedding => "HUGGINGFACE_API_EMBEDDING",
                EmbeddingModelConfigEmbeddingConfigDiscriminatorType.OpenaiEmbedding => "OPENAI_EMBEDDING",
                EmbeddingModelConfigEmbeddingConfigDiscriminatorType.VertexaiEmbedding => "VERTEXAI_EMBEDDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingModelConfigEmbeddingConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_EMBEDDING" => EmbeddingModelConfigEmbeddingConfigDiscriminatorType.AzureEmbedding,
                "BEDROCK_EMBEDDING" => EmbeddingModelConfigEmbeddingConfigDiscriminatorType.BedrockEmbedding,
                "COHERE_EMBEDDING" => EmbeddingModelConfigEmbeddingConfigDiscriminatorType.CohereEmbedding,
                "GEMINI_EMBEDDING" => EmbeddingModelConfigEmbeddingConfigDiscriminatorType.GeminiEmbedding,
                "HUGGINGFACE_API_EMBEDDING" => EmbeddingModelConfigEmbeddingConfigDiscriminatorType.HuggingfaceApiEmbedding,
                "OPENAI_EMBEDDING" => EmbeddingModelConfigEmbeddingConfigDiscriminatorType.OpenaiEmbedding,
                "VERTEXAI_EMBEDDING" => EmbeddingModelConfigEmbeddingConfigDiscriminatorType.VertexaiEmbedding,
                _ => null,
            };
        }
    }
}