//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentUserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedThreadCommentUserType.User => "User",
                WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedThreadCommentUserType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Mannequin,
                _ => null,
            };
        }
    }
}