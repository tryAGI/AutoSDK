//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}