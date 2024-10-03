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
        [global::Newtonsoft.Json.JsonProperty("shardCount")]
        public double? ShardCount { get; set; }

        /// <summary>
        /// The total number of objects in DB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectCount")]
        public double? ObjectCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}