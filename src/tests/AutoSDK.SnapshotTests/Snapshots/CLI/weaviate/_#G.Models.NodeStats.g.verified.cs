//HintName: G.Models.NodeStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary of Weaviate's statistics.
    /// </summary>
    public sealed partial class NodeStats
    {
        /// <summary>
        /// The count of Weaviate's shards. To see this value, set `output` to `verbose`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shardCount")]
        public double? ShardCount { get; set; }

        /// <summary>
        /// The total number of objects in DB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectCount")]
        public double? ObjectCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStats" /> class.
        /// </summary>
        /// <param name="shardCount">
        /// The count of Weaviate's shards. To see this value, set `output` to `verbose`.
        /// </param>
        /// <param name="objectCount">
        /// The total number of objects in DB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeStats(
            double? shardCount,
            double? objectCount)
        {
            this.ShardCount = shardCount;
            this.ObjectCount = objectCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStats" /> class.
        /// </summary>
        public NodeStats()
        {
        }
    }
}