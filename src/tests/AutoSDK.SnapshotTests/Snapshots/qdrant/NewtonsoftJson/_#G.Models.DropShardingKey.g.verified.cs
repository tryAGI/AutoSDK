//HintName: G.Models.DropShardingKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DropShardingKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardKey ShardKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DropShardingKey" /> class.
        /// </summary>
        /// <param name="shardKey"></param>
        public DropShardingKey(
            global::G.ShardKey shardKey)
        {
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DropShardingKey" /> class.
        /// </summary>
        public DropShardingKey()
        {
        }
    }
}