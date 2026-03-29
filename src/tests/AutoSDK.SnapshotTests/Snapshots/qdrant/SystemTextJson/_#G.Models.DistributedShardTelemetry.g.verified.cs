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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Optional shard key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::G.ShardKey? Key { get; set; }

        /// <summary>
        /// Replica information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DistributedReplicaTelemetry> Replicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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