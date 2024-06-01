//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestBaseUserType
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestBaseUserType.User => "User",
                WebhookPullRequestReviewCommentEditedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestBaseUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestBaseUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}