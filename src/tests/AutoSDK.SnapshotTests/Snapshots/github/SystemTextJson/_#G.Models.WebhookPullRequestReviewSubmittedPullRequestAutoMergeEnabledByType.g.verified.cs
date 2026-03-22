//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestReviewSubmittedPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}