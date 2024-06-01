//HintName: G.Models.WebhookOrganizationMemberInvitedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookOrganizationMemberInvitedAction
    {
        /// <summary>
        /// 
        /// </summary>
        MemberInvited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOrganizationMemberInvitedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOrganizationMemberInvitedAction value)
        {
            return value switch
            {
                WebhookOrganizationMemberInvitedAction.MemberInvited => "member_invited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOrganizationMemberInvitedAction ToEnum(string value)
        {
            return value switch
            {
                "member_invited" => WebhookOrganizationMemberInvitedAction.MemberInvited,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}