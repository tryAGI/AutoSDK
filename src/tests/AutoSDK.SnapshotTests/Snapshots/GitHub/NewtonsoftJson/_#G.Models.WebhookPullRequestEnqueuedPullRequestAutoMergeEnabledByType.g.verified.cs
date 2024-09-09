//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}