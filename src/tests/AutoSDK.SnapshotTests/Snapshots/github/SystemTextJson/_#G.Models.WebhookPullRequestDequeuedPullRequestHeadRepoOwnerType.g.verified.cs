//HintName: G.Models.WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestDequeuedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType.Organization,
                "User" => WebhookPullRequestDequeuedPullRequestHeadRepoOwnerType.User,
                _ => null,
            };
        }
    }
}