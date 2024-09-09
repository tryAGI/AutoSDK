//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.Organization,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}