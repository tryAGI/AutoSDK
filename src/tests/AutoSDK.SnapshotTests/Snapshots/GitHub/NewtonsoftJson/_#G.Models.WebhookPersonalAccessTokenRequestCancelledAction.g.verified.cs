//HintName: G.Models.WebhookPersonalAccessTokenRequestCancelledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPersonalAccessTokenRequestCancelledAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPersonalAccessTokenRequestCancelledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPersonalAccessTokenRequestCancelledAction value)
        {
            return value switch
            {
                WebhookPersonalAccessTokenRequestCancelledAction.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPersonalAccessTokenRequestCancelledAction? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => WebhookPersonalAccessTokenRequestCancelledAction.Cancelled,
                _ => null,
            };
        }
    }
}