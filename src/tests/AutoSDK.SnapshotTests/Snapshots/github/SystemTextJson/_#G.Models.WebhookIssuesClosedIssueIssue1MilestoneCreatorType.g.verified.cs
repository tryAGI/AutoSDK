//HintName: G.Models.WebhookIssuesClosedIssueIssue1MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1MilestoneCreatorType
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
    public static class WebhookIssuesClosedIssueIssue1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1MilestoneCreatorType.Bot => "Bot",
                WebhookIssuesClosedIssueIssue1MilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssuesClosedIssueIssue1MilestoneCreatorType.Organization => "Organization",
                WebhookIssuesClosedIssueIssue1MilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueIssue1MilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssuesClosedIssueIssue1MilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssuesClosedIssueIssue1MilestoneCreatorType.Organization,
                "User" => WebhookIssuesClosedIssueIssue1MilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}