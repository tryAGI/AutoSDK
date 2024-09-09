//HintName: G.Models.WebhookPullRequestLockedPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLockedPullRequestMergedByType
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
    public static class WebhookPullRequestLockedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestMergedByType.User => "User",
                WebhookPullRequestLockedPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestLockedPullRequestMergedByType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestMergedByType.Bot,
                "User" => WebhookPullRequestLockedPullRequestMergedByType.User,
                "Organization" => WebhookPullRequestLockedPullRequestMergedByType.Organization,
                "Mannequin" => WebhookPullRequestLockedPullRequestMergedByType.Mannequin,
                _ => null,
            };
        }
    }
}