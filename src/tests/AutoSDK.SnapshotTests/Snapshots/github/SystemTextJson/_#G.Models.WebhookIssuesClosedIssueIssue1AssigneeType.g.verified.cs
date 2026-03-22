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
        Mannequin,
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
                WebhookIssuesClosedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                WebhookIssuesClosedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssuesClosedIssueIssue1AssigneeType.User => "User",
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
                "Mannequin" => WebhookIssuesClosedIssueIssue1AssigneeType.Mannequin,
                "Organization" => WebhookIssuesClosedIssueIssue1AssigneeType.Organization,
                "User" => WebhookIssuesClosedIssueIssue1AssigneeType.User,
                _ => null,
            };
        }
    }
}