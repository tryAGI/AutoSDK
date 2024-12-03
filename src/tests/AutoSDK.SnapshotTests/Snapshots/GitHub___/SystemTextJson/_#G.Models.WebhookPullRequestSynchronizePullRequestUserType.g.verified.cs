//HintName: G.Models.WebhookPullRequestSynchronizePullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestUserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestUserType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestUserType.User => "User",
                WebhookPullRequestSynchronizePullRequestUserType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestUserType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestUserType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestSynchronizePullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}