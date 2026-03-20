//HintName: G.Models.ChatStreamEndEventY8gq2xFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// - `COMPLETE` - the model sent back a finished reply<br/>
    /// - `ERROR_LIMIT` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
    /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens specified by the max_tokens parameter<br/>
    /// - `ERROR` - something went wrong when generating the reply<br/>
    /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
    /// </summary>
    public enum ChatStreamEndEventY8gq2xFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        ErrorLimit,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        ErrorToxic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamEndEventY8gq2xFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamEndEventY8gq2xFinishReason value)
        {
            return value switch
            {
                ChatStreamEndEventY8gq2xFinishReason.Complete => "COMPLETE",
                ChatStreamEndEventY8gq2xFinishReason.ErrorLimit => "ERROR_LIMIT",
                ChatStreamEndEventY8gq2xFinishReason.MaxTokens => "MAX_TOKENS",
                ChatStreamEndEventY8gq2xFinishReason.Error => "ERROR",
                ChatStreamEndEventY8gq2xFinishReason.ErrorToxic => "ERROR_TOXIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamEndEventY8gq2xFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => ChatStreamEndEventY8gq2xFinishReason.Complete,
                "ERROR_LIMIT" => ChatStreamEndEventY8gq2xFinishReason.ErrorLimit,
                "MAX_TOKENS" => ChatStreamEndEventY8gq2xFinishReason.MaxTokens,
                "ERROR" => ChatStreamEndEventY8gq2xFinishReason.Error,
                "ERROR_TOXIC" => ChatStreamEndEventY8gq2xFinishReason.ErrorToxic,
                _ => null,
            };
        }
    }
}