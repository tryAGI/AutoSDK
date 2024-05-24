//HintName: G.Models.OrgMembershipRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The user's membership type in the organization.
    /// <br/>Example: admin
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgMembershipRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="billing_manager")]
        BillingManager,
    }
}