//HintName: G.Models.WebhookPullRequestSynchronizePullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestBaseUserType
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
    public static class WebhookPullRequestSynchronizePullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestBaseUserType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestBaseUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestBaseUserType.Bot,
                "Organization" => WebhookPullRequestSynchronizePullRequestBaseUserType.Organization,
                "User" => WebhookPullRequestSynchronizePullRequestBaseUserType.User,
                _ => null,
            };
        }
    }
}