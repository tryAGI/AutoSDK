//HintName: G.Models.IssueStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the current state
    /// <br/>Example: not_planned
    /// </summary>
    public abstract class IssueStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Completed = "completed";
        /// <summary>
        /// 
        /// </summary>
        public const string Reopened = "reopened";
        /// <summary>
        /// 
        /// </summary>
        public const string NotPlanned = "not_planned";
    }
}