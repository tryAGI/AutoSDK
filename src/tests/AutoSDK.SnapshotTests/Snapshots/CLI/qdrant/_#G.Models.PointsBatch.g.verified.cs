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
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Batch Batch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Filter to apply when updating existing points. Only points matching this filter will be updated. Points that don't match will keep their current state. New points will be inserted regardless of the filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_filter")]
        public global::G.Filter? UpdateFilter { get; set; }

        /// <summary>
        /// Mode of the upsert operation: insert_only, upsert (default), update_only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_mode")]
        public global::G.UpdateMode? UpdateMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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