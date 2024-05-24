//HintName: G.Models.DiscussionState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current state of the discussion.
    /// `converting` means that the discussion is being converted from an issue.
    /// `transferring` means that the discussion is being transferred from another repository.
    /// </summary>
    public abstract class DiscussionState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Open = "open";
        /// <summary>
        /// 
        /// </summary>
        public const string Closed = "closed";
        /// <summary>
        /// 
        /// </summary>
        public const string Locked = "locked";
        /// <summary>
        /// 
        /// </summary>
        public const string Converting = "converting";
        /// <summary>
        /// 
        /// </summary>
        public const string Transferring = "transferring";
    }
}