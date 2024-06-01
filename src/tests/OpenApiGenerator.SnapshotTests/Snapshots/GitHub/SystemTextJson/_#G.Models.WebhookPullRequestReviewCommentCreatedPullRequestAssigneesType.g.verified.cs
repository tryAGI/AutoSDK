//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}