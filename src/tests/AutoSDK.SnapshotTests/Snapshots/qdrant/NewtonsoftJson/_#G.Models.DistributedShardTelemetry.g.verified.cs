//HintName: G.Models.DistributedShardTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributedShardTelemetry
    {
        /// <summary>
        /// Shard ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Optional shard key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public global::G.ShardKey? Key { get; set; }

        /// <summary>
        /// Replica information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replicas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DistributedReplicaTelemetry> Replicas { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedShardTelemetry" /> class.
        /// </summary>
        /// <param name="id">
        /// Shard ID
        /// </param>
        /// <param name="replicas">
        /// Replica information
        /// </param>
        /// <param name="key">
        /// Optional shard key
        /// </param>
        public DistributedShardTelemetry(
            int id,
            global::System.Collections.Generic.IList<global::G.DistributedReplicaTelemetry> replicas,
            global::G.ShardKey? key)
        {
            this.Id = id;
            this.Key = key;
            this.Replicas = replicas ?? throw new global::System.ArgumentNullException(nameof(replicas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedShardTelemetry" /> class.
        /// </summary>
        public DistributedShardTelemetry()
        {
        }
    }
}