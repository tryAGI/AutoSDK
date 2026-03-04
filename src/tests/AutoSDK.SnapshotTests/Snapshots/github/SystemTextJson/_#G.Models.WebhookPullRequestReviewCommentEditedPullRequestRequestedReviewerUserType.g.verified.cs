//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestRequestedReviewerUserType.Organization,
                _ => null,
            };
        }
    }
}