//HintName: G.Models.WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}