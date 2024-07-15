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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
                WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.Organization => "Organization",
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
                "User" => WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}