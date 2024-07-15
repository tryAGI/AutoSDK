//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestUserType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestUserType.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeEnabledPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestUserType.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestUserType.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestAutoMergeEnabledPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}