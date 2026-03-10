//HintName: G.Models.WebhookToolApiSchemaConfigInputContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Content type for the request body. Only applies to POST/PUT/PATCH requests.<br/>
    /// Default Value: application/json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookToolApiSchemaConfigInputContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="application/json")]
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="application/x-www-form-urlencoded")]
        ApplicationXWwwFormUrlencoded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookToolApiSchemaConfigInputContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolApiSchemaConfigInputContentType value)
        {
            return value switch
            {
                WebhookToolApiSchemaConfigInputContentType.ApplicationJson => "application/json",
                WebhookToolApiSchemaConfigInputContentType.ApplicationXWwwFormUrlencoded => "application/x-www-form-urlencoded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookToolApiSchemaConfigInputContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => WebhookToolApiSchemaConfigInputContentType.ApplicationJson,
                "application/x-www-form-urlencoded" => WebhookToolApiSchemaConfigInputContentType.ApplicationXWwwFormUrlencoded,
                _ => null,
            };
        }
    }
}