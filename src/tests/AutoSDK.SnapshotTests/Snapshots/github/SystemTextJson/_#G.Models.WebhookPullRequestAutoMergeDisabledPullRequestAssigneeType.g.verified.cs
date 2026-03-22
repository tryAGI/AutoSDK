//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType.Bot,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}