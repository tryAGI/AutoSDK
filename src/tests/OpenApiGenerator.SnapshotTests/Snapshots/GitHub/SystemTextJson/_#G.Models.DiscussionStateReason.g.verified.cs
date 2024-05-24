//HintName: G.Models.DiscussionStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the current state
    /// <br/>Example: resolved
    /// </summary>
    public abstract class DiscussionStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Resolved = "resolved";
        /// <summary>
        /// 
        /// </summary>
        public const string Outdated = "outdated";
        /// <summary>
        /// 
        /// </summary>
        public const string Duplicate = "duplicate";
        /// <summary>
        /// 
        /// </summary>
        public const string Reopened = "reopened";
    }
}