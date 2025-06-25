//HintName: G.Models.WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestUnlockedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}