//HintName: G.Models.UpdateVectors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVectors
    {
        /// <summary>
        /// Points with named vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PointVectors> Points { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_filter")]
        public global::G.Filter? UpdateFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectors" /> class.
        /// </summary>
        /// <param name="points">
        /// Points with named vectors
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="updateFilter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVectors(
            global::System.Collections.Generic.IList<global::G.PointVectors> points,
            global::G.ShardKeySelector? shardKey,
            global::G.Filter? updateFilter)
        {
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
            this.ShardKey = shardKey;
            this.UpdateFilter = updateFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectors" /> class.
        /// </summary>
        public UpdateVectors()
        {
        }
    }
}