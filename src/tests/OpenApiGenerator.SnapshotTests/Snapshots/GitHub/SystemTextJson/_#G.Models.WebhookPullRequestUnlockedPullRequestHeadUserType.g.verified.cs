//HintName: G.Models.WebhookPullRequestUnlockedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestHeadUserType
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
    public static class WebhookPullRequestUnlockedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestHeadUserType.User => "User",
                WebhookPullRequestUnlockedPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}