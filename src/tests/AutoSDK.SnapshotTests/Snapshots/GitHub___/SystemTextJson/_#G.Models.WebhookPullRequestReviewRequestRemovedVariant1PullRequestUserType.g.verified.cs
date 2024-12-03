//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestUserType.Organization,
                _ => null,
            };
        }
    }
}