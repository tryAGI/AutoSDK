//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType.Bot,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType.Organization,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestBaseUserType.User,
                _ => null,
            };
        }
    }
}