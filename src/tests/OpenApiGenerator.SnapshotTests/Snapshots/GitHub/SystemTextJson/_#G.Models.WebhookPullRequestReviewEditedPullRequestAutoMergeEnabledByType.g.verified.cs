//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestAutoMergeEnabledByType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}