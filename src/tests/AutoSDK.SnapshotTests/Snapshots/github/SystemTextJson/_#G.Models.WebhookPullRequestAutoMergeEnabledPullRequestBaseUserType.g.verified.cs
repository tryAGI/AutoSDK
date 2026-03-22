//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType.Bot,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType.Organization,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestBaseUserType.User,
                _ => null,
            };
        }
    }
}