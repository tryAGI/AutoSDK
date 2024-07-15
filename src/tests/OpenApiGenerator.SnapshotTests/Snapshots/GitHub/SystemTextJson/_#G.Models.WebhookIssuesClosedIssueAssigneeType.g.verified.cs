//HintName: G.Models.WebhookIssuesClosedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueAssigneeType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesClosedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesClosedIssueAssigneeType.User => "User",
                WebhookIssuesClosedIssueAssigneeType.Organization => "Organization",
                WebhookIssuesClosedIssueAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueAssigneeType.Bot,
                "User" => WebhookIssuesClosedIssueAssigneeType.User,
                "Organization" => WebhookIssuesClosedIssueAssigneeType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}