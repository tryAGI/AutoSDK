//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}