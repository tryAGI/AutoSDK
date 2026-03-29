//HintName: G.Models.DistributedCollectionTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributedCollectionTelemetry
    {
        /// <summary>
        /// Collection name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Shards topology
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards")]
        public global::System.Collections.Generic.IList<global::G.DistributedShardTelemetry>? Shards { get; set; }

        /// <summary>
        /// Ongoing resharding operations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reshardings")]
        public global::System.Collections.Generic.IList<global::G.ReshardingInfo>? Reshardings { get; set; }

        /// <summary>
        /// Ongoing shard transfers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_transfers")]
        public global::System.Collections.Generic.IList<global::G.ShardTransferInfo>? ShardTransfers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedCollectionTelemetry" /> class.
        /// </summary>
        /// <param name="id">
        /// Collection name
        /// </param>
        /// <param name="shards">
        /// Shards topology
        /// </param>
        /// <param name="reshardings">
        /// Ongoing resharding operations
        /// </param>
        /// <param name="shardTransfers">
        /// Ongoing shard transfers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributedCollectionTelemetry(
            string id,
            global::System.Collections.Generic.IList<global::G.DistributedShardTelemetry>? shards,
            global::System.Collections.Generic.IList<global::G.ReshardingInfo>? reshardings,
            global::System.Collections.Generic.IList<global::G.ShardTransferInfo>? shardTransfers)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Shards = shards;
            this.Reshardings = reshardings;
            this.ShardTransfers = shardTransfers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedCollectionTelemetry" /> class.
        /// </summary>
        public DistributedCollectionTelemetry()
        {
        }
    }
}