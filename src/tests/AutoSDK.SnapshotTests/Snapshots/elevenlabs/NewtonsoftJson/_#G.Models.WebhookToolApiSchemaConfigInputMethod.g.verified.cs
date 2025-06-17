//HintName: G.Models.WebhookToolApiSchemaConfigInputMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to use for the webhook<br/>
    /// Default Value: GET
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookToolApiSchemaConfigInputMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GET")]
        GET,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POST")]
        POST,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PUT")]
        PUT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PATCH")]
        PATCH,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DELETE")]
        DELETE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookToolApiSchemaConfigInputMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolApiSchemaConfigInputMethod value)
        {
            return value switch
            {
                WebhookToolApiSchemaConfigInputMethod.GET => "GET",
                WebhookToolApiSchemaConfigInputMethod.POST => "POST",
                WebhookToolApiSchemaConfigInputMethod.PUT => "PUT",
                WebhookToolApiSchemaConfigInputMethod.PATCH => "PATCH",
                WebhookToolApiSchemaConfigInputMethod.DELETE => "DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookToolApiSchemaConfigInputMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => WebhookToolApiSchemaConfigInputMethod.GET,
                "POST" => WebhookToolApiSchemaConfigInputMethod.POST,
                "PUT" => WebhookToolApiSchemaConfigInputMethod.PUT,
                "PATCH" => WebhookToolApiSchemaConfigInputMethod.PATCH,
                "DELETE" => WebhookToolApiSchemaConfigInputMethod.DELETE,
                _ => null,
            };
        }
    }
}