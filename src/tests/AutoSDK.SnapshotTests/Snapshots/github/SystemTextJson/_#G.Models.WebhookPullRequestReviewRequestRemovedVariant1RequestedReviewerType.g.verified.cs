//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant1RequestedReviewerType.Organization,
                _ => null,
            };
        }
    }
}