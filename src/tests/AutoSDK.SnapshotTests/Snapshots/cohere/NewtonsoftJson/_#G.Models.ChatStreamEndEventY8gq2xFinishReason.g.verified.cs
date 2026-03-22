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
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatStreamEndEventY8gq2xFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETE")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR_LIMIT")]
        ErrorLimit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR_TOXIC")]
        ErrorToxic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MAX_TOKENS")]
        MaxTokens,
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
                ChatStreamEndEventY8gq2xFinishReason.Error => "ERROR",
                ChatStreamEndEventY8gq2xFinishReason.ErrorLimit => "ERROR_LIMIT",
                ChatStreamEndEventY8gq2xFinishReason.ErrorToxic => "ERROR_TOXIC",
                ChatStreamEndEventY8gq2xFinishReason.MaxTokens => "MAX_TOKENS",
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
                "ERROR" => ChatStreamEndEventY8gq2xFinishReason.Error,
                "ERROR_LIMIT" => ChatStreamEndEventY8gq2xFinishReason.ErrorLimit,
                "ERROR_TOXIC" => ChatStreamEndEventY8gq2xFinishReason.ErrorToxic,
                "MAX_TOKENS" => ChatStreamEndEventY8gq2xFinishReason.MaxTokens,
                _ => null,
            };
        }
    }
}