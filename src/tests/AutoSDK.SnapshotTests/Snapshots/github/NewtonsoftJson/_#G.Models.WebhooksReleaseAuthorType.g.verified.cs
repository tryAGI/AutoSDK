//HintName: G.Models.WebhooksReleaseAuthorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksReleaseAuthorType
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
    public static class WebhooksReleaseAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReleaseAuthorType value)
        {
            return value switch
            {
                WebhooksReleaseAuthorType.Bot => "Bot",
                WebhooksReleaseAuthorType.Organization => "Organization",
                WebhooksReleaseAuthorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReleaseAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReleaseAuthorType.Bot,
                "Organization" => WebhooksReleaseAuthorType.Organization,
                "User" => WebhooksReleaseAuthorType.User,
                _ => null,
            };
        }
    }
}