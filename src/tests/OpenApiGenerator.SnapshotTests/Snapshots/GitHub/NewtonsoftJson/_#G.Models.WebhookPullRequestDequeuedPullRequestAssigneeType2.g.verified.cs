//HintName: G.Models.WebhookPullRequestDequeuedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedPullRequestAssigneeType2
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
    public static class WebhookPullRequestDequeuedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestDequeuedPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestDequeuedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestDequeuedPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}