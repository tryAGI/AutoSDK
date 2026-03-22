//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestReviewSubmittedPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}