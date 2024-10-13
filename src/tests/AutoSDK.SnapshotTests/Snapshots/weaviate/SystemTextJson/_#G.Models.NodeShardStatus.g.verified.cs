//HintName: G.Models.NodeShardStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of a node shard status response body
    /// </summary>
    public sealed partial class NodeShardStatus
    {
        /// <summary>
        /// The name of the shard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The name of shard's class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; set; }

        /// <summary>
        /// The number of objects in shard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectCount")]
        public double? ObjectCount { get; set; }

        /// <summary>
        /// The status of the vector indexing process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorIndexingStatus")]
        public string? VectorIndexingStatus { get; set; }

        /// <summary>
        /// The status of vector compression/quantization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compressed")]
        public bool? Compressed { get; set; }

        /// <summary>
        /// The length of the vector indexing queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorQueueLength")]
        public double? VectorQueueLength { get; set; }

        /// <summary>
        /// The load status of the shard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loaded")]
        public bool? Loaded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
    #if NET6_0_OR_GREATER
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
        public static global::G.NodeShardStatus? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.NodeShardStatus),
                jsonSerializerContext) as global::G.NodeShardStatus;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.NodeShardStatus? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.NodeShardStatus>(
                json,
                jsonSerializerOptions);
        }

    }
}