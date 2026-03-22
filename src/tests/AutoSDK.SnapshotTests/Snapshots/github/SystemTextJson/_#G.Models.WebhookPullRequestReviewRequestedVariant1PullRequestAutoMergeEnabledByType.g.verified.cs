//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}