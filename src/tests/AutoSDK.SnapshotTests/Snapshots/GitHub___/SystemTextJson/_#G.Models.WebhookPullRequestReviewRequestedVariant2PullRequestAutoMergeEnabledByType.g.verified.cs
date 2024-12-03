//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}