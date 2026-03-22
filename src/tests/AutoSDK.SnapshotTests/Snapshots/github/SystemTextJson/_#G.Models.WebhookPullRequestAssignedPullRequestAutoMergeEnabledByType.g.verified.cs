//HintName: G.Models.WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestAssignedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestAssignedPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}