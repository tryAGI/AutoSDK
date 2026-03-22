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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.Bot,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}