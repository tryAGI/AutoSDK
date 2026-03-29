//HintName: G.Models.CollectionParamsShardingMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sharding method Default is Auto - points are distributed across all available shards Custom - points are distributed across shards according to shard key
    /// </summary>
    public sealed partial class CollectionParamsShardingMethod
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}