//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestUserType
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestUserType.User => "User",
                WebhookPullRequestReviewCommentEditedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentEditedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentEditedPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}