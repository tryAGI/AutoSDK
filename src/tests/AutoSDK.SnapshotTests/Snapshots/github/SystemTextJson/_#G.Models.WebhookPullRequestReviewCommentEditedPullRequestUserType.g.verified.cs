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
                WebhookPullRequestReviewCommentEditedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewCommentEditedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewCommentEditedPullRequestUserType.User => "User",
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
                "Mannequin" => WebhookPullRequestReviewCommentEditedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestUserType.Organization,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}