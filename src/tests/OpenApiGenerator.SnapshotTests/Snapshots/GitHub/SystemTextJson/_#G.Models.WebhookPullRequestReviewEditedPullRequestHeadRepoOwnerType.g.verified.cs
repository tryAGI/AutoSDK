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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
                WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestHeadRepoOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}