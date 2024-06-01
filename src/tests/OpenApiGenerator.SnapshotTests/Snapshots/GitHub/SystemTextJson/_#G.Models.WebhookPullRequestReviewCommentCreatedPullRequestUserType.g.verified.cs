//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestUserType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestUserType.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}