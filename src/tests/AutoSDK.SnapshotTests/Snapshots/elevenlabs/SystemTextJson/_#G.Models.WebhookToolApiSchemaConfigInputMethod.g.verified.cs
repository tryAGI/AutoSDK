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
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
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
                WebhookToolApiSchemaConfigInputMethod.Delete => "DELETE",
                WebhookToolApiSchemaConfigInputMethod.Get => "GET",
                WebhookToolApiSchemaConfigInputMethod.Patch => "PATCH",
                WebhookToolApiSchemaConfigInputMethod.Post => "POST",
                WebhookToolApiSchemaConfigInputMethod.Put => "PUT",
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
                "DELETE" => WebhookToolApiSchemaConfigInputMethod.Delete,
                "GET" => WebhookToolApiSchemaConfigInputMethod.Get,
                "PATCH" => WebhookToolApiSchemaConfigInputMethod.Patch,
                "POST" => WebhookToolApiSchemaConfigInputMethod.Post,
                "PUT" => WebhookToolApiSchemaConfigInputMethod.Put,
                _ => null,
            };
        }
    }
}