//HintName: G.Models.WebhookForkForkeeOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookForkForkeeOwnerType
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
    public static class WebhookForkForkeeOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookForkForkeeOwnerType value)
        {
            return value switch
            {
                WebhookForkForkeeOwnerType.Bot => "Bot",
                WebhookForkForkeeOwnerType.User => "User",
                WebhookForkForkeeOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookForkForkeeOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookForkForkeeOwnerType.Bot,
                "User" => WebhookForkForkeeOwnerType.User,
                "Organization" => WebhookForkForkeeOwnerType.Organization,
                _ => null,
            };
        }
    }
}