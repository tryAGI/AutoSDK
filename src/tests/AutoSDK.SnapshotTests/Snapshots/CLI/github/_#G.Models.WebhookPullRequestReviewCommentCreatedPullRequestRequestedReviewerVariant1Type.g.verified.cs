//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}