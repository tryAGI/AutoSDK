//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant1Type.Organization,
                _ => null,
            };
        }
    }
}