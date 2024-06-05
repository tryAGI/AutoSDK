//HintName: G.Models.MessageObjectIncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the message is incomplete.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageObjectIncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_filter")]
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_tokens")]
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_cancelled")]
        RunCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_expired")]
        RunExpired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_failed")]
        RunFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageObjectIncompleteDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageObjectIncompleteDetailsReason value)
        {
            return value switch
            {
                MessageObjectIncompleteDetailsReason.ContentFilter => "content_filter",
                MessageObjectIncompleteDetailsReason.MaxTokens => "max_tokens",
                MessageObjectIncompleteDetailsReason.RunCancelled => "run_cancelled",
                MessageObjectIncompleteDetailsReason.RunExpired => "run_expired",
                MessageObjectIncompleteDetailsReason.RunFailed => "run_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageObjectIncompleteDetailsReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => MessageObjectIncompleteDetailsReason.ContentFilter,
                "max_tokens" => MessageObjectIncompleteDetailsReason.MaxTokens,
                "run_cancelled" => MessageObjectIncompleteDetailsReason.RunCancelled,
                "run_expired" => MessageObjectIncompleteDetailsReason.RunExpired,
                "run_failed" => MessageObjectIncompleteDetailsReason.RunFailed,
                _ => null,
            };
        }
    }
}