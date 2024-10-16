//HintName: G.Models.ChatStreamedResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search_results")]
        SearchResults,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat_info")]
        ChatInfo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation_chunk")]
        GenerationChunk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation_end")]
        GenerationEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation_info")]
        GenerationInfo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="factual_consistency_score")]
        FactualConsistencyScore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end")]
        End,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                ChatStreamedResponseDiscriminatorType.SearchResults => "search_results",
                ChatStreamedResponseDiscriminatorType.ChatInfo => "chat_info",
                ChatStreamedResponseDiscriminatorType.GenerationChunk => "generation_chunk",
                ChatStreamedResponseDiscriminatorType.GenerationEnd => "generation_end",
                ChatStreamedResponseDiscriminatorType.GenerationInfo => "generation_info",
                ChatStreamedResponseDiscriminatorType.FactualConsistencyScore => "factual_consistency_score",
                ChatStreamedResponseDiscriminatorType.End => "end",
                ChatStreamedResponseDiscriminatorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "search_results" => ChatStreamedResponseDiscriminatorType.SearchResults,
                "chat_info" => ChatStreamedResponseDiscriminatorType.ChatInfo,
                "generation_chunk" => ChatStreamedResponseDiscriminatorType.GenerationChunk,
                "generation_end" => ChatStreamedResponseDiscriminatorType.GenerationEnd,
                "generation_info" => ChatStreamedResponseDiscriminatorType.GenerationInfo,
                "factual_consistency_score" => ChatStreamedResponseDiscriminatorType.FactualConsistencyScore,
                "end" => ChatStreamedResponseDiscriminatorType.End,
                "error" => ChatStreamedResponseDiscriminatorType.Error,
                _ => null,
            };
        }
    }
}