//HintName: G.Models.Lora.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Lora
    {
        /// <summary>
        /// Unique identifier for the element. Elements can be found from the List Elements endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("akUUID")]
        public string? AkUUID { get; set; }

        /// <summary>
        /// Name of the creator of the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creatorName")]
        public string? CreatorName { get; set; }

        /// <summary>
        /// Name of the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the element image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urlImage")]
        public string? UrlImage { get; set; }

        /// <summary>
        /// Base model version for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseModel")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Default weight for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightDefault")]
        public int? WeightDefault { get; set; }

        /// <summary>
        /// Minimum weight for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMin")]
        public int? WeightMin { get; set; }

        /// <summary>
        /// Maximum weight for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMax")]
        public int? WeightMax { get; set; }

        /// <summary>
        /// Type name for introspection purposes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("__typename")]
        public string? Typename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.Lora? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Lora>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Lora?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Lora?>(serializer.Deserialize<global::G.Lora>(jsonReader));
        }

    }
}