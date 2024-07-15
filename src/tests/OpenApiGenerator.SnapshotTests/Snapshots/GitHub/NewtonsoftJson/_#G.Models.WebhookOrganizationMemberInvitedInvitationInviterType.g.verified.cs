//HintName: G.Models.WebhookOrganizationMemberInvitedInvitationInviterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookOrganizationMemberInvitedInvitationInviterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOrganizationMemberInvitedInvitationInviterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOrganizationMemberInvitedInvitationInviterType value)
        {
            return value switch
            {
                WebhookOrganizationMemberInvitedInvitationInviterType.Bot => "Bot",
                WebhookOrganizationMemberInvitedInvitationInviterType.User => "User",
                WebhookOrganizationMemberInvitedInvitationInviterType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOrganizationMemberInvitedInvitationInviterType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookOrganizationMemberInvitedInvitationInviterType.Bot,
                "User" => WebhookOrganizationMemberInvitedInvitationInviterType.User,
                "Organization" => WebhookOrganizationMemberInvitedInvitationInviterType.Organization,
                _ => null,
            };
        }
    }
}