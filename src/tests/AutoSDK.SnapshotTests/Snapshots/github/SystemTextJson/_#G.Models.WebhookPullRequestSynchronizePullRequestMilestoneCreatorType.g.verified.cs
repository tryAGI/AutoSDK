//HintName: G.Models.WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestSynchronizePullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}