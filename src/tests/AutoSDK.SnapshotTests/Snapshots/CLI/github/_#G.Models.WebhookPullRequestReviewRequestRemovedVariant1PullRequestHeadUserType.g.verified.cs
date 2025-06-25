//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}