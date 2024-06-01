//HintName: G.Models.WebhookPullRequestLockedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLockedPullRequestBaseUserType
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
    public static class WebhookPullRequestLockedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestBaseUserType.User => "User",
                WebhookPullRequestLockedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestBaseUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestLockedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestLockedPullRequestBaseUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}