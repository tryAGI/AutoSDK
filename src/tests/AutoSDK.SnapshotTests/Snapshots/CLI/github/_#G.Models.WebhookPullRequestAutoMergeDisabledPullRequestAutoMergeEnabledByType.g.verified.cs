//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}