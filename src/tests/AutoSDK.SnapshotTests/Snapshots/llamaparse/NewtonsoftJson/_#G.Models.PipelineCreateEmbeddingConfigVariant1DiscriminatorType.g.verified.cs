//HintName: G.Models.PipelineCreateEmbeddingConfigVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelineCreateEmbeddingConfigVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_EMBEDDING")]
        AzureEmbedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BEDROCK_EMBEDDING")]
        BedrockEmbedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COHERE_EMBEDDING")]
        CohereEmbedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GEMINI_EMBEDDING")]
        GeminiEmbedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HUGGINGFACE_API_EMBEDDING")]
        HuggingfaceApiEmbedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OPENAI_EMBEDDING")]
        OpenaiEmbedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VERTEXAI_EMBEDDING")]
        VertexaiEmbedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineCreateEmbeddingConfigVariant1DiscriminatorType value)
        {
            return value switch
            {
                PipelineCreateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding => "AZURE_EMBEDDING",
                PipelineCreateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding => "BEDROCK_EMBEDDING",
                PipelineCreateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding => "COHERE_EMBEDDING",
                PipelineCreateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding => "GEMINI_EMBEDDING",
                PipelineCreateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding => "HUGGINGFACE_API_EMBEDDING",
                PipelineCreateEmbeddingConfigVariant1DiscriminatorType.OpenaiEmbedding => "OPENAI_EMBEDDING",
                PipelineCreateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding => "VERTEXAI_EMBEDDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineCreateEmbeddingConfigVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_EMBEDDING" => PipelineCreateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding,
                "BEDROCK_EMBEDDING" => PipelineCreateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding,
                "COHERE_EMBEDDING" => PipelineCreateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding,
                "GEMINI_EMBEDDING" => PipelineCreateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding,
                "HUGGINGFACE_API_EMBEDDING" => PipelineCreateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding,
                "OPENAI_EMBEDDING" => PipelineCreateEmbeddingConfigVariant1DiscriminatorType.OpenaiEmbedding,
                "VERTEXAI_EMBEDDING" => PipelineCreateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding,
                _ => null,
            };
        }
    }
}