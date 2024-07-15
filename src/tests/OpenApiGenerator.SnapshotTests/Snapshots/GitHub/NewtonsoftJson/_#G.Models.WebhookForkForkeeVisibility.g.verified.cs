//HintName: G.Models.WebhookForkForkeeVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookForkForkeeVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookForkForkeeVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookForkForkeeVisibility value)
        {
            return value switch
            {
                WebhookForkForkeeVisibility.Public => "public",
                WebhookForkForkeeVisibility.Private => "private",
                WebhookForkForkeeVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookForkForkeeVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookForkForkeeVisibility.Public,
                "private" => WebhookForkForkeeVisibility.Private,
                "internal" => WebhookForkForkeeVisibility.Internal,
                _ => null,
            };
        }
    }
}