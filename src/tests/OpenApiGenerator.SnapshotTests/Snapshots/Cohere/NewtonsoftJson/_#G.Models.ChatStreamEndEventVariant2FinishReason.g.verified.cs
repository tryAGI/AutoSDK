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
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatStreamEndEventVariant2FinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETE")]
        COMPLETE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR_LIMIT")]
        ERRORLIMIT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MAX_TOKENS")]
        MAXTOKENS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        ERROR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR_TOXIC")]
        ERRORTOXIC,
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
                ChatStreamEndEventVariant2FinishReason.COMPLETE => "COMPLETE",
                ChatStreamEndEventVariant2FinishReason.ERRORLIMIT => "ERROR_LIMIT",
                ChatStreamEndEventVariant2FinishReason.MAXTOKENS => "MAX_TOKENS",
                ChatStreamEndEventVariant2FinishReason.ERROR => "ERROR",
                ChatStreamEndEventVariant2FinishReason.ERRORTOXIC => "ERROR_TOXIC",
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
                "COMPLETE" => ChatStreamEndEventVariant2FinishReason.COMPLETE,
                "ERROR_LIMIT" => ChatStreamEndEventVariant2FinishReason.ERRORLIMIT,
                "MAX_TOKENS" => ChatStreamEndEventVariant2FinishReason.MAXTOKENS,
                "ERROR" => ChatStreamEndEventVariant2FinishReason.ERROR,
                "ERROR_TOXIC" => ChatStreamEndEventVariant2FinishReason.ERRORTOXIC,
                _ => null,
            };
        }
    }
}