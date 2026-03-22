//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.Mannequin => "Mannequin",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.Bot,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.Mannequin,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType2.User,
                _ => null,
            };
        }
    }
}