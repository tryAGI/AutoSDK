//HintName: G.Models.WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestUnassignedPullRequestAutoMergeEnabledByType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}