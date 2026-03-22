//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestMergedByType
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
    public static class WebhookPullRequestEnqueuedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestEnqueuedPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestMergedByType.Bot,
                "Organization" => WebhookPullRequestEnqueuedPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestEnqueuedPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}