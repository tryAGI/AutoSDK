//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2.User => "User",
                WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}