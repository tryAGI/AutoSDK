//HintName: G.Models.WebhookToolApiSchemaConfigOutputContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Content type for the request body. Only applies to POST/PUT/PATCH requests.<br/>
    /// Default Value: application/json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookToolApiSchemaConfigOutputContentType
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
    public static class WebhookToolApiSchemaConfigOutputContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolApiSchemaConfigOutputContentType value)
        {
            return value switch
            {
                WebhookToolApiSchemaConfigOutputContentType.ApplicationJson => "application/json",
                WebhookToolApiSchemaConfigOutputContentType.ApplicationXWwwFormUrlencoded => "application/x-www-form-urlencoded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookToolApiSchemaConfigOutputContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => WebhookToolApiSchemaConfigOutputContentType.ApplicationJson,
                "application/x-www-form-urlencoded" => WebhookToolApiSchemaConfigOutputContentType.ApplicationXWwwFormUrlencoded,
                _ => null,
            };
        }
    }
}