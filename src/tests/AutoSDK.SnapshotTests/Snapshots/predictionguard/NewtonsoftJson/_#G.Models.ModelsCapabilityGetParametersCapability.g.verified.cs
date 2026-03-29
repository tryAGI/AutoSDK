//HintName: G.Models.ModelsCapabilityGetParametersCapability.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional path variable to allow for sorting by capability. Leave blank to see all models.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelsCapabilityGetParametersCapability
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat-completion")]
        ChatCompletion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat-with-image")]
        ChatWithImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completion")]
        Completion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="detokenize")]
        Detokenize,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedding")]
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedding-with-image")]
        EmbeddingWithImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning")]
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rerank")]
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tokenize")]
        Tokenize,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calling")]
        ToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsCapabilityGetParametersCapabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsCapabilityGetParametersCapability value)
        {
            return value switch
            {
                ModelsCapabilityGetParametersCapability.ChatCompletion => "chat-completion",
                ModelsCapabilityGetParametersCapability.ChatWithImage => "chat-with-image",
                ModelsCapabilityGetParametersCapability.Completion => "completion",
                ModelsCapabilityGetParametersCapability.Detokenize => "detokenize",
                ModelsCapabilityGetParametersCapability.Embedding => "embedding",
                ModelsCapabilityGetParametersCapability.EmbeddingWithImage => "embedding-with-image",
                ModelsCapabilityGetParametersCapability.Reasoning => "reasoning",
                ModelsCapabilityGetParametersCapability.Rerank => "rerank",
                ModelsCapabilityGetParametersCapability.Tokenize => "tokenize",
                ModelsCapabilityGetParametersCapability.ToolCalling => "tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsCapabilityGetParametersCapability? ToEnum(string value)
        {
            return value switch
            {
                "chat-completion" => ModelsCapabilityGetParametersCapability.ChatCompletion,
                "chat-with-image" => ModelsCapabilityGetParametersCapability.ChatWithImage,
                "completion" => ModelsCapabilityGetParametersCapability.Completion,
                "detokenize" => ModelsCapabilityGetParametersCapability.Detokenize,
                "embedding" => ModelsCapabilityGetParametersCapability.Embedding,
                "embedding-with-image" => ModelsCapabilityGetParametersCapability.EmbeddingWithImage,
                "reasoning" => ModelsCapabilityGetParametersCapability.Reasoning,
                "rerank" => ModelsCapabilityGetParametersCapability.Rerank,
                "tokenize" => ModelsCapabilityGetParametersCapability.Tokenize,
                "tool_calling" => ModelsCapabilityGetParametersCapability.ToolCalling,
                _ => null,
            };
        }
    }
}