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
        [global::System.Runtime.Serialization.EnumMember(Value="DELETE")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GET")]
        Get,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PATCH")]
        Patch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POST")]
        Post,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PUT")]
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