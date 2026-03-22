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
                WebhookPullRequestReviewCommentCreatedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewCommentCreatedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestUserType.Organization,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}