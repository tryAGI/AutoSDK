//HintName: G.Models.WebhookPullRequestLockedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestLockedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestLockedPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestLockedPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestLockedPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}