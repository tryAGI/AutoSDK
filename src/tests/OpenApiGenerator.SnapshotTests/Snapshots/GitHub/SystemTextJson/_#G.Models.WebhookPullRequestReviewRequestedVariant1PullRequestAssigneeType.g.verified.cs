//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}