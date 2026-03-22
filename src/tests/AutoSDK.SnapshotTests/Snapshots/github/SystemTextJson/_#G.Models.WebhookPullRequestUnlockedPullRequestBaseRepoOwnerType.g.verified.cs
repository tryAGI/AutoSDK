//HintName: G.Models.WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestUnlockedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType.Organization => "Organization",
                WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType.Organization,
                "User" => WebhookPullRequestUnlockedPullRequestBaseRepoOwnerType.User,
                _ => null,
            };
        }
    }
}