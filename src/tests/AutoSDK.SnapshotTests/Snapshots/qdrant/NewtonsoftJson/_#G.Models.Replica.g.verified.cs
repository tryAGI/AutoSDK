//HintName: G.Models.Replica.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Replica
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PeerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Replica" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="peerId"></param>
        public Replica(
            int shardId,
            int peerId)
        {
            this.ShardId = shardId;
            this.PeerId = peerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Replica" /> class.
        /// </summary>
        public Replica()
        {
        }
    }
}