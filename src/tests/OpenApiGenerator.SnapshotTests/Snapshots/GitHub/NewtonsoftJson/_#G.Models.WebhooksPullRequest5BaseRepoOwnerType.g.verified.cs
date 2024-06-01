//HintName: G.Models.WebhooksPullRequest5BaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5BaseRepoOwnerType
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
    public static class WebhooksPullRequest5BaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5BaseRepoOwnerType value)
        {
            return value switch
            {
                WebhooksPullRequest5BaseRepoOwnerType.Bot => "Bot",
                WebhooksPullRequest5BaseRepoOwnerType.User => "User",
                WebhooksPullRequest5BaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5BaseRepoOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5BaseRepoOwnerType.Bot,
                "User" => WebhooksPullRequest5BaseRepoOwnerType.User,
                "Organization" => WebhooksPullRequest5BaseRepoOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}