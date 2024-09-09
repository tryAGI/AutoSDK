//HintName: G.Models.WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestSynchronizePullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}