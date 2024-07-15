//HintName: G.Models.WebhookPullRequestLockedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestBaseUserType
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
    public static class WebhookPullRequestLockedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestBaseUserType.User => "User",
                WebhookPullRequestLockedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestLockedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestLockedPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}