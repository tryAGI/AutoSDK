//HintName: G.Models.WebhooksPullRequest5HeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5HeadRepoOwnerType
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
    public static class WebhooksPullRequest5HeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5HeadRepoOwnerType value)
        {
            return value switch
            {
                WebhooksPullRequest5HeadRepoOwnerType.Bot => "Bot",
                WebhooksPullRequest5HeadRepoOwnerType.User => "User",
                WebhooksPullRequest5HeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5HeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5HeadRepoOwnerType.Bot,
                "User" => WebhooksPullRequest5HeadRepoOwnerType.User,
                "Organization" => WebhooksPullRequest5HeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}