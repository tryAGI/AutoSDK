//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedPullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}