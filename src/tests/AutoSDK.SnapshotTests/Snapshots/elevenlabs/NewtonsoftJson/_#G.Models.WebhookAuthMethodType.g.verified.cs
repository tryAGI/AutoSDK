//HintName: G.Models.WebhookAuthMethodType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookAuthMethodType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hmac")]
        Hmac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oauth2")]
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAuthMethodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAuthMethodType value)
        {
            return value switch
            {
                WebhookAuthMethodType.Hmac => "hmac",
                WebhookAuthMethodType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAuthMethodType? ToEnum(string value)
        {
            return value switch
            {
                "hmac" => WebhookAuthMethodType.Hmac,
                "oauth2" => WebhookAuthMethodType.Oauth2,
                _ => null,
            };
        }
    }
}