//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}