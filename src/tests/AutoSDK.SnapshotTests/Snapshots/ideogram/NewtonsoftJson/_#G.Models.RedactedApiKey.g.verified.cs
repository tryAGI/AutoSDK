//HintName: G.Models.RedactedApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A representation of an API key that does not contain the full key.
    /// </summary>
    public sealed partial class RedactedApiKey
    {
        /// <summary>
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key<br/>
        /// Example: vkpDja
        /// </summary>
        /// <example>vkpDja</example>
        [global::Newtonsoft.Json.JsonProperty("redacted_api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string RedactedApiKey1 { get; set; } = default!;

        /// <summary>
        /// The time at which the key was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreationTime { get; set; } = default!;

        /// <summary>
        /// A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </summary>
        /// <example>JRPVD7jWR1aTBYiJ0UFVOg==</example>
        [global::Newtonsoft.Json.JsonProperty("api_key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKeyId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedApiKey" /> class.
        /// </summary>
        /// <param name="redactedApiKey1">
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key<br/>
        /// Example: vkpDja
        /// </param>
        /// <param name="creationTime">
        /// The time at which the key was created
        /// </param>
        /// <param name="apiKeyId">
        /// A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </param>
        public RedactedApiKey(
            string redactedApiKey1,
            global::System.DateTime creationTime,
            string apiKeyId)
        {
            this.RedactedApiKey1 = redactedApiKey1 ?? throw new global::System.ArgumentNullException(nameof(redactedApiKey1));
            this.CreationTime = creationTime;
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedApiKey" /> class.
        /// </summary>
        public RedactedApiKey()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RedactedApiKey? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RedactedApiKey>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RedactedApiKey?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RedactedApiKey?>(serializer.Deserialize<global::G.RedactedApiKey>(jsonReader));
        }

    }
}