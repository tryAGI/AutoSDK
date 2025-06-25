//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType.User => "User",
                WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}