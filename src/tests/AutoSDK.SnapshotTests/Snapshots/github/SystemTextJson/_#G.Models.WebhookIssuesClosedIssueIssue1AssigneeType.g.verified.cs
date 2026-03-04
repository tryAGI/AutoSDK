//HintName: G.Models.WebhookIssuesClosedIssueIssue1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1AssigneeType
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
    public static class WebhookIssuesClosedIssueIssue1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1AssigneeType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1AssigneeType.Bot => "Bot",
                WebhookIssuesClosedIssueIssue1AssigneeType.User => "User",
                WebhookIssuesClosedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssuesClosedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueIssue1AssigneeType.Bot,
                "User" => WebhookIssuesClosedIssueIssue1AssigneeType.User,
                "Organization" => WebhookIssuesClosedIssueIssue1AssigneeType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueIssue1AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}