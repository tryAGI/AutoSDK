//HintName: G.Models.OrgsListPendingInvitationsRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    public enum OrgsListPendingInvitationsRole
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        DirectMember,
        /// <summary>
        /// 
        /// </summary>
        BillingManager,
        /// <summary>
        /// 
        /// </summary>
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
                OrgsListPendingInvitationsRole.All => "all",
                OrgsListPendingInvitationsRole.Admin => "admin",
                OrgsListPendingInvitationsRole.DirectMember => "direct_member",
                OrgsListPendingInvitationsRole.BillingManager => "billing_manager",
                OrgsListPendingInvitationsRole.HiringManager => "hiring_manager",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListPendingInvitationsRole ToEnum(string value)
        {
            return value switch
            {
                "all" => OrgsListPendingInvitationsRole.All,
                "admin" => OrgsListPendingInvitationsRole.Admin,
                "direct_member" => OrgsListPendingInvitationsRole.DirectMember,
                "billing_manager" => OrgsListPendingInvitationsRole.BillingManager,
                "hiring_manager" => OrgsListPendingInvitationsRole.HiringManager,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}