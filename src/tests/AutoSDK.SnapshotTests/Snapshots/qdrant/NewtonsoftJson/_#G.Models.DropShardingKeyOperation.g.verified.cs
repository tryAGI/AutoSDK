//HintName: G.Models.DropShardingKeyOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DropShardingKeyOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("drop_sharding_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DropShardingKey DropShardingKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DropShardingKeyOperation" /> class.
        /// </summary>
        /// <param name="dropShardingKey"></param>
        public DropShardingKeyOperation(
            global::G.DropShardingKey dropShardingKey)
        {
            this.DropShardingKey = dropShardingKey ?? throw new global::System.ArgumentNullException(nameof(dropShardingKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DropShardingKeyOperation" /> class.
        /// </summary>
        public DropShardingKeyOperation()
        {
        }
    }
}