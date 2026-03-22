//HintName: G.Models.WebhookIssuesOpenedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssueAssigneeType2
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesOpenedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesOpenedIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesOpenedIssueAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedIssueAssigneeType2.Bot,
                "Organization" => WebhookIssuesOpenedIssueAssigneeType2.Organization,
                "User" => WebhookIssuesOpenedIssueAssigneeType2.User,
                _ => null,
            };
        }
    }
}