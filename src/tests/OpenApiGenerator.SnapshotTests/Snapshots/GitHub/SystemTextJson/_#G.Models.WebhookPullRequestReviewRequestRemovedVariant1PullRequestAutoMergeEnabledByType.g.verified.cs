//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}