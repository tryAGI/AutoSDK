//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}