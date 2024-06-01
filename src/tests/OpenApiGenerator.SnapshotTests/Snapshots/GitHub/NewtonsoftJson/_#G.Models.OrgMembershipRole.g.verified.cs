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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgMembershipRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgMembershipRole value)
        {
            return value switch
            {
                OrgMembershipRole.Admin => "admin",
                OrgMembershipRole.Member => "member",
                OrgMembershipRole.BillingManager => "billing_manager",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgMembershipRole ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrgMembershipRole.Admin,
                "member" => OrgMembershipRole.Member,
                "billing_manager" => OrgMembershipRole.BillingManager,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}