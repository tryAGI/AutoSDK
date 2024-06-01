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
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}