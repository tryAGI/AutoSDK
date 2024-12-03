//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestAssigneeType2
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
    public static class WebhookPullRequestUnlabeledPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestAssigneeType2.User => "User",
                WebhookPullRequestUnlabeledPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestUnlabeledPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestAssigneeType2.Organization,
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}