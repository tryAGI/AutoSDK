//HintName: G.Models.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineUpdateEmbeddingConfigVariant1DiscriminatorType
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
    public static class PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineUpdateEmbeddingConfigVariant1DiscriminatorType value)
        {
            return value switch
            {
                PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding => "AZURE_EMBEDDING",
                PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding => "BEDROCK_EMBEDDING",
                PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding => "COHERE_EMBEDDING",
                PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding => "GEMINI_EMBEDDING",
                PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding => "HUGGINGFACE_API_EMBEDDING",
                PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.OpenaiEmbedding => "OPENAI_EMBEDDING",
                PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding => "VERTEXAI_EMBEDDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_EMBEDDING" => PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding,
                "BEDROCK_EMBEDDING" => PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding,
                "COHERE_EMBEDDING" => PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding,
                "GEMINI_EMBEDDING" => PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding,
                "HUGGINGFACE_API_EMBEDDING" => PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding,
                "OPENAI_EMBEDDING" => PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.OpenaiEmbedding,
                "VERTEXAI_EMBEDDING" => PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding,
                _ => null,
            };
        }
    }
}