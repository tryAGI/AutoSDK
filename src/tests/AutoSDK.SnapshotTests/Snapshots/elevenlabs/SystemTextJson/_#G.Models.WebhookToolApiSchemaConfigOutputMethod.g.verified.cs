//HintName: G.Models.WebhookToolApiSchemaConfigOutputMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to use for the webhook<br/>
    /// Default Value: GET
    /// </summary>
    public enum WebhookToolApiSchemaConfigOutputMethod
    {
        /// <summary>
        /// 
        /// </summary>
        GET,
        /// <summary>
        /// 
        /// </summary>
        POST,
        /// <summary>
        /// 
        /// </summary>
        PUT,
        /// <summary>
        /// 
        /// </summary>
        PATCH,
        /// <summary>
        /// 
        /// </summary>
        DELETE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookToolApiSchemaConfigOutputMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolApiSchemaConfigOutputMethod value)
        {
            return value switch
            {
                WebhookToolApiSchemaConfigOutputMethod.GET => "GET",
                WebhookToolApiSchemaConfigOutputMethod.POST => "POST",
                WebhookToolApiSchemaConfigOutputMethod.PUT => "PUT",
                WebhookToolApiSchemaConfigOutputMethod.PATCH => "PATCH",
                WebhookToolApiSchemaConfigOutputMethod.DELETE => "DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookToolApiSchemaConfigOutputMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => WebhookToolApiSchemaConfigOutputMethod.GET,
                "POST" => WebhookToolApiSchemaConfigOutputMethod.POST,
                "PUT" => WebhookToolApiSchemaConfigOutputMethod.PUT,
                "PATCH" => WebhookToolApiSchemaConfigOutputMethod.PATCH,
                "DELETE" => WebhookToolApiSchemaConfigOutputMethod.DELETE,
                _ => null,
            };
        }
    }
}