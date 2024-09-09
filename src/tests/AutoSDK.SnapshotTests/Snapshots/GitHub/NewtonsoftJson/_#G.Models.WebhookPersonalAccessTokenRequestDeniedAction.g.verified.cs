//HintName: G.Models.WebhookPersonalAccessTokenRequestDeniedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPersonalAccessTokenRequestDeniedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="denied")]
        Denied,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPersonalAccessTokenRequestDeniedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPersonalAccessTokenRequestDeniedAction value)
        {
            return value switch
            {
                WebhookPersonalAccessTokenRequestDeniedAction.Denied => "denied",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPersonalAccessTokenRequestDeniedAction? ToEnum(string value)
        {
            return value switch
            {
                "denied" => WebhookPersonalAccessTokenRequestDeniedAction.Denied,
                _ => null,
            };
        }
    }
}