//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}