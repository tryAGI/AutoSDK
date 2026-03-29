//HintName: G.Models.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType
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