//HintName: G.Models.ChatStreamedResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResults,
        /// <summary>
        /// 
        /// </summary>
        ChatInfo,
        /// <summary>
        /// 
        /// </summary>
        GenerationChunk,
        /// <summary>
        /// 
        /// </summary>
        GenerationEnd,
        /// <summary>
        /// 
        /// </summary>
        GenerationInfo,
        /// <summary>
        /// 
        /// </summary>
        FactualConsistencyScore,
        /// <summary>
        /// 
        /// </summary>
        End,
        /// <summary>
        /// 
        /// </summary>
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