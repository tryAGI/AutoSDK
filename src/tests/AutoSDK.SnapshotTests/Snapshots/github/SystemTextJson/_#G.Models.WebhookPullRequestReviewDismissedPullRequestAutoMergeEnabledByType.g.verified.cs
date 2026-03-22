//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}