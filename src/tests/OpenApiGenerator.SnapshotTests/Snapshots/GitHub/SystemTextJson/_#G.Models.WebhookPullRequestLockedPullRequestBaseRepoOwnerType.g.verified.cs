//HintName: G.Models.WebhookPullRequestLockedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestLockedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestLockedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestBaseRepoOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestLockedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestLockedPullRequestBaseRepoOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}