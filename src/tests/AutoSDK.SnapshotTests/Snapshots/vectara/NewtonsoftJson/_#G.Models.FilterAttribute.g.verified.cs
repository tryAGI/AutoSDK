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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Indicates whether this is a document or document part metadata filter.<br/>
        /// Example: document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterAttributeLevel Level { get; set; } = default!;

        /// <summary>
        /// Description of the filter. May be omitted.<br/>
        /// Example: The title of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether an index should be created for the filter. Creating an index will improve query latency when using the filter.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexed")]
        public bool? Indexed { get; set; }

        /// <summary>
        /// The value type of the filter.<br/>
        /// Example: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterAttributeType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.FilterAttribute? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FilterAttribute>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.FilterAttribute?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.FilterAttribute?>(serializer.Deserialize<global::G.FilterAttribute>(jsonReader));
        }

    }
}