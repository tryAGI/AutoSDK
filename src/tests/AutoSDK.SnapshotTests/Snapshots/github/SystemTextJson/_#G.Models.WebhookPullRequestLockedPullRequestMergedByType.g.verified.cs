//HintName: G.Models.WebhookPullRequestLockedPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestMergedByType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
    public static class WebhookPullRequestLockedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestMergedByType.Mannequin => "Mannequin",
                WebhookPullRequestLockedPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestLockedPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestMergedByType.Bot,
                "Mannequin" => WebhookPullRequestLockedPullRequestMergedByType.Mannequin,
                "Organization" => WebhookPullRequestLockedPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestLockedPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}