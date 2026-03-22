//HintName: G.Models.WebhookPullRequestLockedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLockedPullRequestUserType
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
    public static class WebhookPullRequestLockedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestLockedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestLockedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestLockedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestLockedPullRequestUserType.Organization,
                "User" => WebhookPullRequestLockedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}