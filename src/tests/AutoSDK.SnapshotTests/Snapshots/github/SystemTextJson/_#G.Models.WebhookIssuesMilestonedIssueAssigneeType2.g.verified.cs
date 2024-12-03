//HintName: G.Models.WebhookIssuesMilestonedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesMilestonedIssueAssigneeType2
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
    public static class WebhookIssuesMilestonedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesMilestonedIssueAssigneeType2.User => "User",
                WebhookIssuesMilestonedIssueAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesMilestonedIssueAssigneeType2.Bot,
                "User" => WebhookIssuesMilestonedIssueAssigneeType2.User,
                "Organization" => WebhookIssuesMilestonedIssueAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}