//HintName: G.Models.WebhookPullRequestAssignedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAssignedPullRequestUserType
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
    public static class WebhookPullRequestAssignedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestAssignedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestAssignedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestAssignedPullRequestUserType.Organization,
                "User" => WebhookPullRequestAssignedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}