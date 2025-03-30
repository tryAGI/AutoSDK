//HintName: G.Models.WebhookToolApiSchemaConfigInputMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to use for the webhook<br/>
    /// Default Value: GET
    /// </summary>
    public enum WebhookToolApiSchemaConfigInputMethod
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
        PATCH,
        /// <summary>
        /// 
        /// </summary>
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
                "PATCH" => WebhookToolApiSchemaConfigInputMethod.PATCH,
                "DELETE" => WebhookToolApiSchemaConfigInputMethod.DELETE,
                _ => null,
            };
        }
    }
}