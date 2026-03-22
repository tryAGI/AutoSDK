//HintName: G.Models.WebhookPullRequestDequeuedPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestMergedByType
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
    public static class WebhookPullRequestDequeuedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestMergedByType.Bot,
                "Organization" => WebhookPullRequestDequeuedPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestDequeuedPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}