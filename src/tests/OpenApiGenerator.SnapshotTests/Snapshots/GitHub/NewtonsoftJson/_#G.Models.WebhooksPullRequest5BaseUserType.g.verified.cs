//HintName: G.Models.WebhooksPullRequest5BaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5BaseUserType
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
    public static class WebhooksPullRequest5BaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5BaseUserType value)
        {
            return value switch
            {
                WebhooksPullRequest5BaseUserType.Bot => "Bot",
                WebhooksPullRequest5BaseUserType.User => "User",
                WebhooksPullRequest5BaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5BaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5BaseUserType.Bot,
                "User" => WebhooksPullRequest5BaseUserType.User,
                "Organization" => WebhooksPullRequest5BaseUserType.Organization,
                _ => null,
            };
        }
    }
}