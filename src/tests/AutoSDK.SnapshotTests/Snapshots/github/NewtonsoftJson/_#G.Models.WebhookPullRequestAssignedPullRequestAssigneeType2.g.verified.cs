//HintName: G.Models.WebhookPullRequestAssignedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAssignedPullRequestAssigneeType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAssignedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestAssigneeType2.Mannequin => "Mannequin",
                WebhookPullRequestAssignedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestAssigneeType2.Bot,
                "Mannequin" => WebhookPullRequestAssignedPullRequestAssigneeType2.Mannequin,
                "Organization" => WebhookPullRequestAssignedPullRequestAssigneeType2.Organization,
                "User" => WebhookPullRequestAssignedPullRequestAssigneeType2.User,
                _ => null,
            };
        }
    }
}