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
                WebhookIssuesReopenedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssuesReopenedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesReopenedIssueMilestoneCreatorType.User => "User",
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
                "Mannequin" => WebhookIssuesReopenedIssueMilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssuesReopenedIssueMilestoneCreatorType.Organization,
                "User" => WebhookIssuesReopenedIssueMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}