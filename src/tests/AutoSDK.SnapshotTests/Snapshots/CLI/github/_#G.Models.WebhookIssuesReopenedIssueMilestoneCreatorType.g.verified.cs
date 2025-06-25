//HintName: G.Models.WebhookIssuesReopenedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssueMilestoneCreatorType
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
    public static class WebhookIssuesReopenedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesReopenedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesReopenedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesReopenedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesReopenedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesReopenedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesReopenedIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}