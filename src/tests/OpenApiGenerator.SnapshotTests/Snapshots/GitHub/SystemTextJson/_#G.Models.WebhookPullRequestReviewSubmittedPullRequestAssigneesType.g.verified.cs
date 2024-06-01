//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestAssigneesType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}