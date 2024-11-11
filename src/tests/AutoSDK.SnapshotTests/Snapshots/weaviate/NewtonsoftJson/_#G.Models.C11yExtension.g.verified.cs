//HintName: G.Models.C11yExtension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A resource describing an extension to the contextinoary, containing both the identifier and the definition of the extension
    /// </summary>
    public sealed partial class C11yExtension
    {
        /// <summary>
        /// The new concept you want to extend. Must be an all-lowercase single word, or a space delimited compound word. Examples: 'foobarium', 'my custom concept'<br/>
        /// Example: foobarium
        /// </summary>
        /// <example>foobarium</example>
        [global::Newtonsoft.Json.JsonProperty("concept")]
        public string? Concept { get; set; }

        /// <summary>
        /// A list of space-delimited words or a sentence describing what the custom concept is about. Avoid using the custom concept itself. An Example definition for the custom concept 'foobarium': would be 'a naturally occurring element which can only be seen by programmers'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("definition")]
        public string? Definition { get; set; }

        /// <summary>
        /// Weight of the definition of the new concept where 1='override existing definition entirely' and 0='ignore custom definition'. Note that if the custom concept is not present in the contextionary yet, the weight cannot be less than 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yExtension" /> class.
        /// </summary>
        /// <param name="concept">
        /// The new concept you want to extend. Must be an all-lowercase single word, or a space delimited compound word. Examples: 'foobarium', 'my custom concept'<br/>
        /// Example: foobarium
        /// </param>
        /// <param name="definition">
        /// A list of space-delimited words or a sentence describing what the custom concept is about. Avoid using the custom concept itself. An Example definition for the custom concept 'foobarium': would be 'a naturally occurring element which can only be seen by programmers'
        /// </param>
        /// <param name="weight">
        /// Weight of the definition of the new concept where 1='override existing definition entirely' and 0='ignore custom definition'. Note that if the custom concept is not present in the contextionary yet, the weight cannot be less than 1.
        /// </param>
        public C11yExtension(
            string? concept,
            string? definition,
            float? weight)
        {
            this.Concept = concept;
            this.Definition = definition;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yExtension" /> class.
        /// </summary>
        public C11yExtension()
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
        public static global::G.C11yExtension? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.C11yExtension>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.C11yExtension?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.C11yExtension?>(serializer.Deserialize<global::G.C11yExtension>(jsonReader));
        }

    }
}