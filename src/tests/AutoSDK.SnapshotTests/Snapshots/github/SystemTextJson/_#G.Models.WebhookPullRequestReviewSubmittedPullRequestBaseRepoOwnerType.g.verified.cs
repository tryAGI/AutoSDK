//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.Organization,
                "User" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.User,
                _ => null,
            };
        }
    }
}