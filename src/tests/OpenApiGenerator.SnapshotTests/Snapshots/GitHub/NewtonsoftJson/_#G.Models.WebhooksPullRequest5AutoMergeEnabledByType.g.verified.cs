//HintName: G.Models.WebhooksPullRequest5AutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5AutoMergeEnabledByType
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
    public static class WebhooksPullRequest5AutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5AutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhooksPullRequest5AutoMergeEnabledByType.Bot => "Bot",
                WebhooksPullRequest5AutoMergeEnabledByType.User => "User",
                WebhooksPullRequest5AutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5AutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5AutoMergeEnabledByType.Bot,
                "User" => WebhooksPullRequest5AutoMergeEnabledByType.User,
                "Organization" => WebhooksPullRequest5AutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}