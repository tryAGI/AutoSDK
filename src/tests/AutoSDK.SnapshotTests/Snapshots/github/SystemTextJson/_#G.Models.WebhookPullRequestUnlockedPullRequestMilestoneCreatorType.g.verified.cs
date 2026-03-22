//HintName: G.Models.WebhookPullRequestUnlockedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestUnlockedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestUnlockedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestMilestoneCreatorType.Bot,
                "Organization" => WebhookPullRequestUnlockedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestUnlockedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}