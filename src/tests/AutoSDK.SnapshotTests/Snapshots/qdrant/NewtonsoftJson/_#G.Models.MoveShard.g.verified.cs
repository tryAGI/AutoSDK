//HintName: G.Models.MoveShard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MoveShard
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ToPeerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int FromPeerId { get; set; } = default!;

        /// <summary>
        /// Method for transferring the shard from one node to another
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        public global::G.ShardTransferMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveShard" /> class.
        /// </summary>
        /// <param name="shardId"></param>
        /// <param name="toPeerId"></param>
        /// <param name="fromPeerId"></param>
        /// <param name="method">
        /// Method for transferring the shard from one node to another
        /// </param>
        public MoveShard(
            int shardId,
            int toPeerId,
            int fromPeerId,
            global::G.ShardTransferMethod? method)
        {
            this.ShardId = shardId;
            this.ToPeerId = toPeerId;
            this.FromPeerId = fromPeerId;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveShard" /> class.
        /// </summary>
        public MoveShard()
        {
        }
    }
}