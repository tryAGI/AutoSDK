//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}