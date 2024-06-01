//HintName: G.Models.WebhookPullRequestAssignedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAssignedPullRequestAssigneeType
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
    public static class WebhookPullRequestAssignedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestAssigneeType.User => "User",
                WebhookPullRequestAssignedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestAssignedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestAssignedPullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestAssignedPullRequestAssigneeType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}