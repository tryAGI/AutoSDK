//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewCommentEditedPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}