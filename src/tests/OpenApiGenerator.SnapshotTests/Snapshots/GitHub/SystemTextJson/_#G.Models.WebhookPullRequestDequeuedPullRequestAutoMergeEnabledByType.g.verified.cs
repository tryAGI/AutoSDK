//HintName: G.Models.WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestDequeuedPullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}