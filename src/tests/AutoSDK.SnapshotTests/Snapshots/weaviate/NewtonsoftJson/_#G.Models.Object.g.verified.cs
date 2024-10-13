//HintName: G.Models.Object.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Object
    {
        /// <summary>
        /// The object collection name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Allow custom overrides of vector weights as math expressions in word-based vectorization models. E.g. "pancake": "7" will set the weight for the word pancake to 7 in the vectorization, whereas "w * 3" would triple the originally calculated word.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectorWeights")]
        public object? VectorWeights { get; set; }

        /// <summary>
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// ID of the object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// (Response only) Timestamp of creation of this object in milliseconds since epoch UTC.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creationTimeUnix")]
        public long? CreationTimeUnix { get; set; }

        /// <summary>
        /// (Response only) Timestamp of the last object update in milliseconds since epoch UTC.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUpdateTimeUnix")]
        public long? LastUpdateTimeUnix { get; set; }

        /// <summary>
        /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector")]
        public global::System.Collections.Generic.IList<float>? Vector { get; set; }

        /// <summary>
        /// A map of named vectors for multi-vector representations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectors")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<float>>? Vectors { get; set; }

        /// <summary>
        /// Name of the tenant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// (Response only) Additional meta information about a single object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional")]
        public global::System.Collections.Generic.Dictionary<string, object>? Additional { get; set; }

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
        public static global::G.Object? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Object>(
                json,
                jsonSerializerOptions);
        }

    }
}