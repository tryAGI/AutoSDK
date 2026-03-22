//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.Organization,
                "User" => WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.User,
                _ => null,
            };
        }
    }
}