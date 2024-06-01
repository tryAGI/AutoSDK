//HintName: G.Models.OrgsCreateInvitationRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role for the new member. 
    ///  * `admin` - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.  
    ///  * `direct_member` - Non-owner organization members with ability to see other members and join teams by invitation.  
    ///  * `billing_manager` - Non-owner organization members with ability to manage the billing settings of your organization. 
    ///  * `reinstate` - The previous role assigned to the invitee before they were removed from your organization. Can be one of the roles listed above. Only works if the invitee was previously part of your organization.
    /// <br/>Default Value: direct_member
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsCreateInvitationRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct_member")]
        DirectMember,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="billing_manager")]
        BillingManager,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reinstate")]
        Reinstate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsCreateInvitationRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsCreateInvitationRequestRole value)
        {
            return value switch
            {
                OrgsCreateInvitationRequestRole.Admin => "admin",
                OrgsCreateInvitationRequestRole.DirectMember => "direct_member",
                OrgsCreateInvitationRequestRole.BillingManager => "billing_manager",
                OrgsCreateInvitationRequestRole.Reinstate => "reinstate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsCreateInvitationRequestRole ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrgsCreateInvitationRequestRole.Admin,
                "direct_member" => OrgsCreateInvitationRequestRole.DirectMember,
                "billing_manager" => OrgsCreateInvitationRequestRole.BillingManager,
                "reinstate" => OrgsCreateInvitationRequestRole.Reinstate,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}