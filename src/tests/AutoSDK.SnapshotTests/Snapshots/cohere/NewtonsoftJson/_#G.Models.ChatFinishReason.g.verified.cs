//HintName: G.Models.ChatFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason a chat request has finished.<br/>
    /// - **complete**: The model finished sending a complete message.<br/>
    /// - **max_tokens**: The number of generated tokens exceeded the model's context length or the value specified via the `max_tokens` parameter.<br/>
    /// - **stop_sequence**: One of the provided `stop_sequence` entries was reached in the model's generation.<br/>
    /// - **tool_call**: The model generated a Tool Call and is expecting a Tool Message in return<br/>
    /// - **error**: The generation failed due to an internal error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETE")]
        COMPLETE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STOP_SEQUENCE")]
        STOPSEQUENCE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MAX_TOKENS")]
        MAXTOKENS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOOL_CALL")]
        TOOLCALL,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        ERROR,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFinishReason value)
        {
            return value switch
            {
                ChatFinishReason.COMPLETE => "COMPLETE",
                ChatFinishReason.STOPSEQUENCE => "STOP_SEQUENCE",
                ChatFinishReason.MAXTOKENS => "MAX_TOKENS",
                ChatFinishReason.TOOLCALL => "TOOL_CALL",
                ChatFinishReason.ERROR => "ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => ChatFinishReason.COMPLETE,
                "STOP_SEQUENCE" => ChatFinishReason.STOPSEQUENCE,
                "MAX_TOKENS" => ChatFinishReason.MAXTOKENS,
                "TOOL_CALL" => ChatFinishReason.TOOLCALL,
                "ERROR" => ChatFinishReason.ERROR,
                _ => null,
            };
        }
    }
}