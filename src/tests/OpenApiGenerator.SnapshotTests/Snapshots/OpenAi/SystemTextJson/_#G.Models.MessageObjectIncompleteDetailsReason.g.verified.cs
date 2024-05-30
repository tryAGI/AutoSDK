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

    public static class MessageObjectIncompleteDetailsReasonExtensions
    {
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
        public static MessageObjectIncompleteDetailsReason ToEnum(int value)
        {
            return value switch
            {
                0 => MessageObjectIncompleteDetailsReason.ContentFilter,
                1 => MessageObjectIncompleteDetailsReason.MaxTokens,
                2 => MessageObjectIncompleteDetailsReason.RunCancelled,
                3 => MessageObjectIncompleteDetailsReason.RunExpired,
                4 => MessageObjectIncompleteDetailsReason.RunFailed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}