//HintName: G.Models.WebhookPullRequestUnassignedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestAssigneeType2
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnassignedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestUnassignedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestUnassignedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestUnassignedPullRequestAssigneeType2.Organization,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}