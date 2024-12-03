//HintName: G.Models.WebhookIssuesClosedIssueVariant1MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueVariant1MilestoneCreatorType
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
    public static class WebhookIssuesClosedIssueVariant1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1MilestoneCreatorType.Bot => "Bot",
                WebhookIssuesClosedIssueVariant1MilestoneCreatorType.User => "User",
                WebhookIssuesClosedIssueVariant1MilestoneCreatorType.Organization => "Organization",
                WebhookIssuesClosedIssueVariant1MilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueVariant1MilestoneCreatorType.Bot,
                "User" => WebhookIssuesClosedIssueVariant1MilestoneCreatorType.User,
                "Organization" => WebhookIssuesClosedIssueVariant1MilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueVariant1MilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}