//HintName: G.Models.WebhookPullRequestLockedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestHeadUserType
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
    public static class WebhookPullRequestLockedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestHeadUserType.User => "User",
                WebhookPullRequestLockedPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestLockedPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestLockedPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}