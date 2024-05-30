//HintName: G.Models.MessageObjectIncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the message is incomplete.
    /// </summary>
    public enum MessageObjectIncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        RunCancelled,
        /// <summary>
        /// 
        /// </summary>
        RunExpired,
        /// <summary>
        /// 
        /// </summary>
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
        public static MessageObjectIncompleteDetailsReason ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => MessageObjectIncompleteDetailsReason.ContentFilter,
                "max_tokens" => MessageObjectIncompleteDetailsReason.MaxTokens,
                "run_cancelled" => MessageObjectIncompleteDetailsReason.RunCancelled,
                "run_expired" => MessageObjectIncompleteDetailsReason.RunExpired,
                "run_failed" => MessageObjectIncompleteDetailsReason.RunFailed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}