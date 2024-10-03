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
    }
}