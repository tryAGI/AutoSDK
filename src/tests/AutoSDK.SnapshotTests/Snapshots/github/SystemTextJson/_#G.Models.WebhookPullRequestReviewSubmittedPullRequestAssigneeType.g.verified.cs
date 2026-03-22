//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Bot,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}