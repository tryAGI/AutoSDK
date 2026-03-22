//HintName: G.Models.WebhookPullRequestSynchronizePullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestMergedByType
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
    public static class WebhookPullRequestSynchronizePullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestMergedByType.Bot,
                "Organization" => WebhookPullRequestSynchronizePullRequestMergedByType.Organization,
                "User" => WebhookPullRequestSynchronizePullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}