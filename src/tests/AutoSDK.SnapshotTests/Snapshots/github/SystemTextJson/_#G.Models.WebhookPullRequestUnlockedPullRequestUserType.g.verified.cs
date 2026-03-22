//HintName: G.Models.WebhookPullRequestUnlockedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestUserType
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
    public static class WebhookPullRequestUnlockedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestUnlockedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestUserType.Bot,
                "Organization" => WebhookPullRequestUnlockedPullRequestUserType.Organization,
                "User" => WebhookPullRequestUnlockedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}