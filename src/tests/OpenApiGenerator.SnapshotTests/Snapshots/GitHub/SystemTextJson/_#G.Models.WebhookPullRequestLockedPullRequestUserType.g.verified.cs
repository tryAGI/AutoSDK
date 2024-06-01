//HintName: G.Models.WebhookPullRequestLockedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestUserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLockedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestUserType.User => "User",
                WebhookPullRequestLockedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestLockedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestUserType.Bot,
                "User" => WebhookPullRequestLockedPullRequestUserType.User,
                "Organization" => WebhookPullRequestLockedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestLockedPullRequestUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}