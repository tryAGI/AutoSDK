//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestUserType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestAutoMergeEnabledPullRequestUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeEnabledPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestAutoMergeEnabledPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestUserType.Organization,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestUserType.User,
                _ => null,
            };
        }
    }
}