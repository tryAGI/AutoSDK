//HintName: G.Models.OrgsListPendingInvitationsRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsListPendingInvitationsRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="billing_manager")]
        BillingManager,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct_member")]
        DirectMember,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hiring_manager")]
        HiringManager,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsListPendingInvitationsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListPendingInvitationsRole value)
        {
            return value switch
            {
                OrgsListPendingInvitationsRole.Admin => "admin",
                OrgsListPendingInvitationsRole.All => "all",
                OrgsListPendingInvitationsRole.BillingManager => "billing_manager",
                OrgsListPendingInvitationsRole.DirectMember => "direct_member",
                OrgsListPendingInvitationsRole.HiringManager => "hiring_manager",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListPendingInvitationsRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrgsListPendingInvitationsRole.Admin,
                "all" => OrgsListPendingInvitationsRole.All,
                "billing_manager" => OrgsListPendingInvitationsRole.BillingManager,
                "direct_member" => OrgsListPendingInvitationsRole.DirectMember,
                "hiring_manager" => OrgsListPendingInvitationsRole.HiringManager,
                _ => null,
            };
        }
    }
}