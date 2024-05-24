//HintName: G.Models.NullableIssueStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the current state
    /// <br/>Example: not_planned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NullableIssueStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reopened")]
        Reopened,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_planned")]
        NotPlanned,
    }
}