//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestMergedByType
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.User => "User",
                WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestMergedByType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.Bot,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.User,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}