//HintName: G.Models.WebhookOrganizationMemberInvitedInvitationInviterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookOrganizationMemberInvitedInvitationInviterType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
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