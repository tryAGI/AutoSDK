//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestMilestoneCreatorType.Organization,
                _ => null,
            };
        }
    }
}