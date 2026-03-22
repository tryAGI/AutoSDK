//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewCommentDeletedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentDeletedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewCommentDeletedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestUserType.Organization,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}