//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1RequestedReviewerType
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
    public static class WebhookPullRequestReviewRequestedVariant1RequestedReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1RequestedReviewerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.User => "User",
                WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1RequestedReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.Organization,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant1RequestedReviewerType.Mannequin,
                _ => null,
            };
        }
    }
}