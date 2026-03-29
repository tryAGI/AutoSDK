//HintName: G.Models.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType
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
    public static class EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType value)
        {
            return value switch
            {
                EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding => "AZURE_EMBEDDING",
                EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding => "BEDROCK_EMBEDDING",
                EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding => "COHERE_EMBEDDING",
                EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding => "GEMINI_EMBEDDING",
                EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding => "HUGGINGFACE_API_EMBEDDING",
                EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.OpenaiEmbedding => "OPENAI_EMBEDDING",
                EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding => "VERTEXAI_EMBEDDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_EMBEDDING" => EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding,
                "BEDROCK_EMBEDDING" => EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding,
                "COHERE_EMBEDDING" => EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding,
                "GEMINI_EMBEDDING" => EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding,
                "HUGGINGFACE_API_EMBEDDING" => EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding,
                "OPENAI_EMBEDDING" => EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.OpenaiEmbedding,
                "VERTEXAI_EMBEDDING" => EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding,
                _ => null,
            };
        }
    }
}