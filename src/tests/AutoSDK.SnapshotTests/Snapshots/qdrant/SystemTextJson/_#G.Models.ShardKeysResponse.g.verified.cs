//HintName: G.Models.ShardKeysResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardKeysResponse
    {
        /// <summary>
        /// The existing shard keys. Only available when sharding method is `custom`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_keys")]
        public global::System.Collections.Generic.IList<global::G.ShardKeyDescription>? ShardKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardKeysResponse" /> class.
        /// </summary>
        /// <param name="shardKeys">
        /// The existing shard keys. Only available when sharding method is `custom`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShardKeysResponse(
            global::System.Collections.Generic.IList<global::G.ShardKeyDescription>? shardKeys)
        {
            this.ShardKeys = shardKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardKeysResponse" /> class.
        /// </summary>
        public ShardKeysResponse()
        {
        }
    }
}