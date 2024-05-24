//HintName: G.Models.DiscussionStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the current state
    /// <br/>Example: resolved
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiscussionStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outdated")]
        Outdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="duplicate")]
        Duplicate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reopened")]
        Reopened,
    }
}