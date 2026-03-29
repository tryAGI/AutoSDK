//HintName: G.Models.PipelineEmbeddingConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineEmbeddingConfigDiscriminatorType
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
        ManagedOpenaiEmbedding,
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
    public static class PipelineEmbeddingConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineEmbeddingConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelineEmbeddingConfigDiscriminatorType.AzureEmbedding => "AZURE_EMBEDDING",
                PipelineEmbeddingConfigDiscriminatorType.BedrockEmbedding => "BEDROCK_EMBEDDING",
                PipelineEmbeddingConfigDiscriminatorType.CohereEmbedding => "COHERE_EMBEDDING",
                PipelineEmbeddingConfigDiscriminatorType.GeminiEmbedding => "GEMINI_EMBEDDING",
                PipelineEmbeddingConfigDiscriminatorType.HuggingfaceApiEmbedding => "HUGGINGFACE_API_EMBEDDING",
                PipelineEmbeddingConfigDiscriminatorType.ManagedOpenaiEmbedding => "MANAGED_OPENAI_EMBEDDING",
                PipelineEmbeddingConfigDiscriminatorType.OpenaiEmbedding => "OPENAI_EMBEDDING",
                PipelineEmbeddingConfigDiscriminatorType.VertexaiEmbedding => "VERTEXAI_EMBEDDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineEmbeddingConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_EMBEDDING" => PipelineEmbeddingConfigDiscriminatorType.AzureEmbedding,
                "BEDROCK_EMBEDDING" => PipelineEmbeddingConfigDiscriminatorType.BedrockEmbedding,
                "COHERE_EMBEDDING" => PipelineEmbeddingConfigDiscriminatorType.CohereEmbedding,
                "GEMINI_EMBEDDING" => PipelineEmbeddingConfigDiscriminatorType.GeminiEmbedding,
                "HUGGINGFACE_API_EMBEDDING" => PipelineEmbeddingConfigDiscriminatorType.HuggingfaceApiEmbedding,
                "MANAGED_OPENAI_EMBEDDING" => PipelineEmbeddingConfigDiscriminatorType.ManagedOpenaiEmbedding,
                "OPENAI_EMBEDDING" => PipelineEmbeddingConfigDiscriminatorType.OpenaiEmbedding,
                "VERTEXAI_EMBEDDING" => PipelineEmbeddingConfigDiscriminatorType.VertexaiEmbedding,
                _ => null,
            };
        }
    }
}