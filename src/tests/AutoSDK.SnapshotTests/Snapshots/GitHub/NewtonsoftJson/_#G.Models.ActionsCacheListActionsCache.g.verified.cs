//HintName: G.Models.ActionsCacheListActionsCache.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsCacheListActionsCache
    {
        /// <summary>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: refs/heads/main
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Example: Linux-node-958aff96db2d75d67787d1e634ae70b659de937b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Example: 73885106f58cc52a7df9ec4d4a5622a5614813162cb516c759a30af6bf56e6f0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_accessed_at")]
        public global::System.DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: 1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_in_bytes")]
        public int? SizeInBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheListActionsCache" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 2
        /// </param>
        /// <param name="ref">
        /// Example: refs/heads/main
        /// </param>
        /// <param name="key">
        /// Example: Linux-node-958aff96db2d75d67787d1e634ae70b659de937b
        /// </param>
        /// <param name="version">
        /// Example: 73885106f58cc52a7df9ec4d4a5622a5614813162cb516c759a30af6bf56e6f0
        /// </param>
        /// <param name="lastAccessedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="sizeInBytes">
        /// Example: 1024
        /// </param>
        public ActionsCacheListActionsCache(
            int? id,
            string? @ref,
            string? key,
            string? version,
            global::System.DateTime? lastAccessedAt,
            global::System.DateTime? createdAt,
            int? sizeInBytes)
        {
            this.Id = id;
            this.Ref = @ref;
            this.Key = key;
            this.Version = version;
            this.LastAccessedAt = lastAccessedAt;
            this.CreatedAt = createdAt;
            this.SizeInBytes = sizeInBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheListActionsCache" /> class.
        /// </summary>
        public ActionsCacheListActionsCache()
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
        public static global::G.ActionsCacheListActionsCache? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ActionsCacheListActionsCache>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ActionsCacheListActionsCache?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ActionsCacheListActionsCache?>(serializer.Deserialize<global::G.ActionsCacheListActionsCache>(jsonReader));
        }

    }
}