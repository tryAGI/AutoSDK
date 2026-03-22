//HintName: G.Models.WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
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
    public static class WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestUnlockedPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}