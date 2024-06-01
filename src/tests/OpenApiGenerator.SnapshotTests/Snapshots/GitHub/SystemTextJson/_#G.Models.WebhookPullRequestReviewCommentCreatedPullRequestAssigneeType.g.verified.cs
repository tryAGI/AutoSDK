//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}