//HintName: G.Models.WebhookPullRequestUnlockedPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestMergedByType
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
    public static class WebhookPullRequestUnlockedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestMergedByType.User => "User",
                WebhookPullRequestUnlockedPullRequestMergedByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestMergedByType.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestMergedByType.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestMergedByType.Organization,
                _ => null,
            };
        }
    }
}