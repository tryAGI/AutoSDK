//HintName: G.Models.WebhookIssuesClosedIssueIssue1AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1AssigneeType2
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
    public static class WebhookIssuesClosedIssueIssue1AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1AssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1AssigneeType2.Bot => "Bot",
                WebhookIssuesClosedIssueIssue1AssigneeType2.Mannequin => "Mannequin",
                WebhookIssuesClosedIssueIssue1AssigneeType2.Organization => "Organization",
                WebhookIssuesClosedIssueIssue1AssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueIssue1AssigneeType2.Bot,
                "Mannequin" => WebhookIssuesClosedIssueIssue1AssigneeType2.Mannequin,
                "Organization" => WebhookIssuesClosedIssueIssue1AssigneeType2.Organization,
                "User" => WebhookIssuesClosedIssueIssue1AssigneeType2.User,
                _ => null,
            };
        }
    }
}