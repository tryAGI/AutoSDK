//HintName: G.Models.WebhookPullRequestLockedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhookPullRequestLockedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestLockedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestMilestoneCreatorType.Bot,
                "Organization" => WebhookPullRequestLockedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestLockedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}