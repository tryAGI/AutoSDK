//HintName: G.Models.WebhookPullRequestReviewCommentCreatedCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedCommentUserType
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
    public static class WebhookPullRequestReviewCommentCreatedCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedCommentUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedCommentUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedCommentUserType.User => "User",
                WebhookPullRequestReviewCommentCreatedCommentUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedCommentUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedCommentUserType.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedCommentUserType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedCommentUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}