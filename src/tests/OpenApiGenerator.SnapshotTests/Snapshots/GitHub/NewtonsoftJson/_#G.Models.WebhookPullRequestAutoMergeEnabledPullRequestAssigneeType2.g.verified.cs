//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestAssigneeType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
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