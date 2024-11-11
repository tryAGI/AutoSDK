//HintName: G.Models.FilterAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterAttribute
    {
        /// <summary>
        /// The JSON path of the filter attribute in a document or document part metadata.<br/>
        /// Example: Title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Indicates whether this is a document or document part metadata filter.<br/>
        /// Example: document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterAttributeLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterAttributeLevel Level { get; set; }

        /// <summary>
        /// Description of the filter. May be omitted.<br/>
        /// Example: The title of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether an index should be created for the filter. Creating an index will improve query latency when using the filter.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexed")]
        public bool? Indexed { get; set; }

        /// <summary>
        /// The value type of the filter.<br/>
        /// Example: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterAttributeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterAttributeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttribute" /> class.
        /// </summary>
        /// <param name="name">
        /// The JSON path of the filter attribute in a document or document part metadata.<br/>
        /// Example: Title
        /// </param>
        /// <param name="level">
        /// Indicates whether this is a document or document part metadata filter.<br/>
        /// Example: document
        /// </param>
        /// <param name="description">
        /// Description of the filter. May be omitted.<br/>
        /// Example: The title of the document.
        /// </param>
        /// <param name="indexed">
        /// Indicates whether an index should be created for the filter. Creating an index will improve query latency when using the filter.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type">
        /// The value type of the filter.<br/>
        /// Example: text
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FilterAttribute(
            string name,
            global::G.FilterAttributeLevel level,
            global::G.FilterAttributeType type,
            string? description,
            bool? indexed)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Level = level;
            this.Type = type;
            this.Description = description;
            this.Indexed = indexed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttribute" /> class.
        /// </summary>
        public FilterAttribute()
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
        public static global::G.FilterAttribute? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.FilterAttribute),
                jsonSerializerContext) as global::G.FilterAttribute;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.FilterAttribute? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.FilterAttribute>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.FilterAttribute?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.FilterAttribute),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.FilterAttribute;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.FilterAttribute?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.FilterAttribute?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}