//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestAssigneeType.Organization,
                _ => null,
            };
        }
    }
}