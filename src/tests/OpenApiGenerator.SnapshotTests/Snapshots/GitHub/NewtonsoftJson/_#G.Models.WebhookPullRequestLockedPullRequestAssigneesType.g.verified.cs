//HintName: G.Models.WebhookPullRequestLockedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLockedPullRequestAssigneesType
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
    public static class WebhookPullRequestLockedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestAssigneesType.User => "User",
                WebhookPullRequestLockedPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestLockedPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestLockedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestLockedPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestLockedPullRequestAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}