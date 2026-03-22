//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.Organization,
                "User" => WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.User,
                _ => null,
            };
        }
    }
}