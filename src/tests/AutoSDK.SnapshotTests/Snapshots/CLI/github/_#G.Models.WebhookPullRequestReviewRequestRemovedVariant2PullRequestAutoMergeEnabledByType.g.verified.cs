//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}