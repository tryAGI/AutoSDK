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
        Get,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Delete,
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
                WebhookToolApiSchemaConfigInputMethod.Get => "GET",
                WebhookToolApiSchemaConfigInputMethod.Post => "POST",
                WebhookToolApiSchemaConfigInputMethod.Put => "PUT",
                WebhookToolApiSchemaConfigInputMethod.Patch => "PATCH",
                WebhookToolApiSchemaConfigInputMethod.Delete => "DELETE",
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
                "GET" => WebhookToolApiSchemaConfigInputMethod.Get,
                "POST" => WebhookToolApiSchemaConfigInputMethod.Post,
                "PUT" => WebhookToolApiSchemaConfigInputMethod.Put,
                "PATCH" => WebhookToolApiSchemaConfigInputMethod.Patch,
                "DELETE" => WebhookToolApiSchemaConfigInputMethod.Delete,
                _ => null,
            };
        }
    }
}