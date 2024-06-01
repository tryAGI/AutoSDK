//HintName: G.Models.WebhookOrganizationMemberRemovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookOrganizationMemberRemovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        MemberRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOrganizationMemberRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOrganizationMemberRemovedAction value)
        {
            return value switch
            {
                WebhookOrganizationMemberRemovedAction.MemberRemoved => "member_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOrganizationMemberRemovedAction ToEnum(string value)
        {
            return value switch
            {
                "member_removed" => WebhookOrganizationMemberRemovedAction.MemberRemoved,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}