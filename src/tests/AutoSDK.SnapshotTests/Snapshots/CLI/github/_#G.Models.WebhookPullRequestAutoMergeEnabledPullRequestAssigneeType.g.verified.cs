//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType.Organization,
                _ => null,
            };
        }
    }
}