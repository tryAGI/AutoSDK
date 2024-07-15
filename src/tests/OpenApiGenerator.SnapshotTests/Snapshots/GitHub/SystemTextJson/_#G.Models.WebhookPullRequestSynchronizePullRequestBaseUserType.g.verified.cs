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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
                WebhookPullRequestSynchronizePullRequestBaseUserType.User => "User",
                WebhookPullRequestSynchronizePullRequestBaseUserType.Organization => "Organization",
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
                "User" => WebhookPullRequestSynchronizePullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}