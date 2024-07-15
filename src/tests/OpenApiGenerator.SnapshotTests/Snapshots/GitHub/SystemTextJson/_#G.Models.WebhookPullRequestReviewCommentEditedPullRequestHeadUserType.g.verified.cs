//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestHeadUserType
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestHeadUserType.User => "User",
                WebhookPullRequestReviewCommentEditedPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}