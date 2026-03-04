//HintName: G.Models.ChatStreamEndEventVariant2FinishReason.g.cs

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
    public enum ChatStreamEndEventVariant2FinishReason
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
    public static class ChatStreamEndEventVariant2FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamEndEventVariant2FinishReason value)
        {
            return value switch
            {
                ChatStreamEndEventVariant2FinishReason.Complete => "COMPLETE",
                ChatStreamEndEventVariant2FinishReason.ErrorLimit => "ERROR_LIMIT",
                ChatStreamEndEventVariant2FinishReason.MaxTokens => "MAX_TOKENS",
                ChatStreamEndEventVariant2FinishReason.Error => "ERROR",
                ChatStreamEndEventVariant2FinishReason.ErrorToxic => "ERROR_TOXIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamEndEventVariant2FinishReason? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => ChatStreamEndEventVariant2FinishReason.Complete,
                "ERROR_LIMIT" => ChatStreamEndEventVariant2FinishReason.ErrorLimit,
                "MAX_TOKENS" => ChatStreamEndEventVariant2FinishReason.MaxTokens,
                "ERROR" => ChatStreamEndEventVariant2FinishReason.Error,
                "ERROR_TOXIC" => ChatStreamEndEventVariant2FinishReason.ErrorToxic,
                _ => null,
            };
        }
    }
}