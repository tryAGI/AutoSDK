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
                WebhookPullRequestAutoMergeDisabledPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestAutoMergeDisabledPullRequestUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestAutoMergeDisabledPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestUserType.Organization,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestUserType.User,
                _ => null,
            };
        }
    }
}