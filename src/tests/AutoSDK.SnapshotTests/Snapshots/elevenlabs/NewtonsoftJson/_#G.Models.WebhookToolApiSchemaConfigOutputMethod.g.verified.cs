//HintName: G.Models.WebhookToolApiSchemaConfigOutputMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to use for the webhook<br/>
    /// Default Value: GET
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookToolApiSchemaConfigOutputMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GET")]
        Get,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PATCH")]
        Patch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DELETE")]
        Delete,
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
                WebhookToolApiSchemaConfigOutputMethod.Get => "GET",
                WebhookToolApiSchemaConfigOutputMethod.Post => "POST",
                WebhookToolApiSchemaConfigOutputMethod.Put => "PUT",
                WebhookToolApiSchemaConfigOutputMethod.Patch => "PATCH",
                WebhookToolApiSchemaConfigOutputMethod.Delete => "DELETE",
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
                "GET" => WebhookToolApiSchemaConfigOutputMethod.Get,
                "POST" => WebhookToolApiSchemaConfigOutputMethod.Post,
                "PUT" => WebhookToolApiSchemaConfigOutputMethod.Put,
                "PATCH" => WebhookToolApiSchemaConfigOutputMethod.Patch,
                "DELETE" => WebhookToolApiSchemaConfigOutputMethod.Delete,
                _ => null,
            };
        }
    }
}