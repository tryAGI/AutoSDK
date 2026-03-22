//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}