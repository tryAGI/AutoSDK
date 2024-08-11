//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}