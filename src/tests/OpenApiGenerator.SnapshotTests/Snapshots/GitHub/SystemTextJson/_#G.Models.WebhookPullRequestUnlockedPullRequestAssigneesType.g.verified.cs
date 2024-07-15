//HintName: G.Models.WebhookPullRequestUnlockedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestAssigneesType
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
    public static class WebhookPullRequestUnlockedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestAssigneesType.User => "User",
                WebhookPullRequestUnlockedPullRequestAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestAssigneesType.Organization,
                _ => null,
            };
        }
    }
}