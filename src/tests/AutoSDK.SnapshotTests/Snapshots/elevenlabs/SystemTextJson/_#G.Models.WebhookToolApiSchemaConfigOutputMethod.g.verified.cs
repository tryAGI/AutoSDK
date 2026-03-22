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
    public static class WebhookToolApiSchemaConfigOutputMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolApiSchemaConfigOutputMethod value)
        {
            return value switch
            {
                WebhookToolApiSchemaConfigOutputMethod.Delete => "DELETE",
                WebhookToolApiSchemaConfigOutputMethod.Get => "GET",
                WebhookToolApiSchemaConfigOutputMethod.Patch => "PATCH",
                WebhookToolApiSchemaConfigOutputMethod.Post => "POST",
                WebhookToolApiSchemaConfigOutputMethod.Put => "PUT",
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
                "DELETE" => WebhookToolApiSchemaConfigOutputMethod.Delete,
                "GET" => WebhookToolApiSchemaConfigOutputMethod.Get,
                "PATCH" => WebhookToolApiSchemaConfigOutputMethod.Patch,
                "POST" => WebhookToolApiSchemaConfigOutputMethod.Post,
                "PUT" => WebhookToolApiSchemaConfigOutputMethod.Put,
                _ => null,
            };
        }
    }
}