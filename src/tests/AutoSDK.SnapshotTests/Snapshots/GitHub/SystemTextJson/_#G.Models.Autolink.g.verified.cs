//HintName: G.Models.Autolink.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An autolink reference.
    /// </summary>
    public sealed partial class Autolink
    {
        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The prefix of a key that is linkified.<br/>
        /// Example: TICKET-
        /// </summary>
        /// <example>TICKET-</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyPrefix { get; set; }

        /// <summary>
        /// A template for the target URL that is generated if a key was found.<br/>
        /// Example: https://example.com/TICKET?query=&lt;num&gt;
        /// </summary>
        /// <example>https://example.com/TICKET?query=&lt;num&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UrlTemplate { get; set; }

        /// <summary>
        /// Whether this autolink reference matches alphanumeric characters. If false, this autolink reference only matches numeric characters.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_alphanumeric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAlphanumeric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Autolink" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 3
        /// </param>
        /// <param name="keyPrefix">
        /// The prefix of a key that is linkified.<br/>
        /// Example: TICKET-
        /// </param>
        /// <param name="urlTemplate">
        /// A template for the target URL that is generated if a key was found.<br/>
        /// Example: https://example.com/TICKET?query=&lt;num&gt;
        /// </param>
        /// <param name="isAlphanumeric">
        /// Whether this autolink reference matches alphanumeric characters. If false, this autolink reference only matches numeric characters.<br/>
        /// Example: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Autolink(
            int id,
            string keyPrefix,
            string urlTemplate,
            bool isAlphanumeric)
        {
            this.Id = id;
            this.KeyPrefix = keyPrefix ?? throw new global::System.ArgumentNullException(nameof(keyPrefix));
            this.UrlTemplate = urlTemplate ?? throw new global::System.ArgumentNullException(nameof(urlTemplate));
            this.IsAlphanumeric = isAlphanumeric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Autolink" /> class.
        /// </summary>
        public Autolink()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.Autolink? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Autolink),
                jsonSerializerContext) as global::G.Autolink;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Autolink? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Autolink>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Autolink?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Autolink),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Autolink;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Autolink?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Autolink?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}