//HintName: G.Models.WebhookToolApiSchemaConfigOutputContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Content type for the request body. Only applies to POST/PUT/PATCH requests.<br/>
    /// Default Value: application/json
    /// </summary>
    public enum WebhookToolApiSchemaConfigOutputContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividejson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividexWwwFormUrlencoded,
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
                WebhookToolApiSchemaConfigOutputContentType.ApplicationDividejson => "application/json",
                WebhookToolApiSchemaConfigOutputContentType.ApplicationDividexWwwFormUrlencoded => "application/x-www-form-urlencoded",
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
                "application/json" => WebhookToolApiSchemaConfigOutputContentType.ApplicationDividejson,
                "application/x-www-form-urlencoded" => WebhookToolApiSchemaConfigOutputContentType.ApplicationDividexWwwFormUrlencoded,
                _ => null,
            };
        }
    }
}