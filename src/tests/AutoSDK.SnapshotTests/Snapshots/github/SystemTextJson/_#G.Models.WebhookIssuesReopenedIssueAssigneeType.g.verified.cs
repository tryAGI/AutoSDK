//HintName: G.Models.WebhookIssuesReopenedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssueAssigneeType
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
    public static class WebhookIssuesReopenedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesReopenedIssueAssigneeType.Organization => "Organization",
                WebhookIssuesReopenedIssueAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssueAssigneeType.Bot,
                "Organization" => WebhookIssuesReopenedIssueAssigneeType.Organization,
                "User" => WebhookIssuesReopenedIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}