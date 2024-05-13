//HintName: G.Models.MessageObjectIncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the message is incomplete.
    /// </summary>
    public abstract class MessageObjectIncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ContentFilter = "content_filter";
        /// <summary>
        /// 
        /// </summary>
        public const string MaxTokens = "max_tokens";
        /// <summary>
        /// 
        /// </summary>
        public const string RunCancelled = "run_cancelled";
        /// <summary>
        /// 
        /// </summary>
        public const string RunExpired = "run_expired";
        /// <summary>
        /// 
        /// </summary>
        public const string RunFailed = "run_failed";
    }
}