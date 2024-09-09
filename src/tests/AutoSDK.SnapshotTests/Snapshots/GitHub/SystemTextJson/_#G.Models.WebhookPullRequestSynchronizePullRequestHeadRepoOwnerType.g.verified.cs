//HintName: G.Models.WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestSynchronizePullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}