//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}