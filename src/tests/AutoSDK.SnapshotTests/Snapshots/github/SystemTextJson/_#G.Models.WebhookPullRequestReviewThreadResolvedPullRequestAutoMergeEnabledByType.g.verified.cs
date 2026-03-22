//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}