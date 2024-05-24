//HintName: G.Models.OrgMembershipState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.
    /// <br/>Example: active
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgMembershipState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }
}