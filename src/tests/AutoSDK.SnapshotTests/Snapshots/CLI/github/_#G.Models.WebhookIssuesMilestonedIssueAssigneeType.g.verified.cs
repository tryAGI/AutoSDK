//HintName: G.Models.WebhookIssuesMilestonedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesMilestonedIssueAssigneeType
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
    public static class WebhookIssuesMilestonedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesMilestonedIssueAssigneeType.User => "User",
                WebhookIssuesMilestonedIssueAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesMilestonedIssueAssigneeType.Bot,
                "User" => WebhookIssuesMilestonedIssueAssigneeType.User,
                "Organization" => WebhookIssuesMilestonedIssueAssigneeType.Organization,
                _ => null,
            };
        }
    }
}