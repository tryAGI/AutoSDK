//HintName: G.Models.EnvironmentApprovalsState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether deployment to the environment(s) was approved or rejected or pending (with comments)
    /// <br/>Example: approved
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnvironmentApprovalsState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approved")]
        Approved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }
}