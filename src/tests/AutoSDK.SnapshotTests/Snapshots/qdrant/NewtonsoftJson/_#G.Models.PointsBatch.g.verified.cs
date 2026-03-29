//HintName: G.Models.PointsBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PointsBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Batch Batch { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Filter to apply when updating existing points. Only points matching this filter will be updated. Points that don't match will keep their current state. New points will be inserted regardless of the filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_filter")]
        public global::G.Filter? UpdateFilter { get; set; }

        /// <summary>
        /// Mode of the upsert operation: insert_only, upsert (default), update_only
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_mode")]
        public global::G.UpdateMode? UpdateMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointsBatch" /> class.
        /// </summary>
        /// <param name="batch"></param>
        /// <param name="shardKey"></param>
        /// <param name="updateFilter">
        /// Filter to apply when updating existing points. Only points matching this filter will be updated. Points that don't match will keep their current state. New points will be inserted regardless of the filter.
        /// </param>
        /// <param name="updateMode">
        /// Mode of the upsert operation: insert_only, upsert (default), update_only
        /// </param>
        public PointsBatch(
            global::G.Batch batch,
            global::G.ShardKeySelector? shardKey,
            global::G.Filter? updateFilter,
            global::G.UpdateMode? updateMode)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
            this.ShardKey = shardKey;
            this.UpdateFilter = updateFilter;
            this.UpdateMode = updateMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointsBatch" /> class.
        /// </summary>
        public PointsBatch()
        {
        }
    }
}