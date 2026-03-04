//HintName: G.Models.WebhookForkForkeeRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookForkForkeeRepositoryOwnerType
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
    public static class WebhookForkForkeeRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookForkForkeeRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookForkForkeeRepositoryOwnerType.Bot => "Bot",
                WebhookForkForkeeRepositoryOwnerType.User => "User",
                WebhookForkForkeeRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookForkForkeeRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookForkForkeeRepositoryOwnerType.Bot,
                "User" => WebhookForkForkeeRepositoryOwnerType.User,
                "Organization" => WebhookForkForkeeRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}