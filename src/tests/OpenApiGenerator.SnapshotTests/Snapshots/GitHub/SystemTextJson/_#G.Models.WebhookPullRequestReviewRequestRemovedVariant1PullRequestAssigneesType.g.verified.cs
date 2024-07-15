//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAssigneesType.Organization,
                _ => null,
            };
        }
    }
}