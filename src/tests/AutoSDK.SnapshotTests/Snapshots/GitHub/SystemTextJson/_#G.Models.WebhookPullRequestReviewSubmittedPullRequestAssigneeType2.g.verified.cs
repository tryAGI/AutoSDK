//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewSubmittedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}