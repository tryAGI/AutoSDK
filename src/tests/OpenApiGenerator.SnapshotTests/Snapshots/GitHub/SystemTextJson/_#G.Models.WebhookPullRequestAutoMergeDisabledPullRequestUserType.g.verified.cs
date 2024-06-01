//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestUserType
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestUserType.User => "User",
                WebhookPullRequestAutoMergeDisabledPullRequestUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestUserType.Bot,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestUserType.User,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestAutoMergeDisabledPullRequestUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}