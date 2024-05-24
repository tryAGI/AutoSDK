//HintName: G.Models.DiscussionState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current state of the discussion.
    /// `converting` means that the discussion is being converted from an issue.
    /// `transferring` means that the discussion is being transferred from another repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiscussionState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="locked")]
        Locked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="converting")]
        Converting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transferring")]
        Transferring,
    }
}